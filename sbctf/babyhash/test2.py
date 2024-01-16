import frida
import subprocess
import sys

def on_message(message, data):
    print("[*] Received message:", message)
    if "success" in message:
        print(f"Success! Input: {message['input']}")
        # 在这里添加停止爆破过程的逻辑
        sys.exit(0)

def run_frida_script(target_process, input_string):
    # 1. 启动目标程序
    process = subprocess.Popen(target_process, stdin=subprocess.PIPE, stdout=subprocess.PIPE, stderr=subprocess.PIPE, text=True)
    pid = process.pid

    # 2. 创建 Frida 会话并附加到目标进程
    session = frida.attach(pid)

    # 3. 读取 Frida 脚本
    with open("frida_script2.js", "r", encoding='utf-8') as f:
        script_code = f.read()

    # 4. 创建脚本并设置消息回调
    script = session.create_script(script_code)
    script.on("message", on_message)

    # 5. 将输入字符串传递给脚本
    script.post({"input_string": input_string})

    # 6. 加载脚本
    script.load()

    # 7. 保持脚本运行
    sys.stdin.read()

if __name__ == "__main__":
    # 替换为目标程序的路径或命令
    target_process = ["babyhash.exe"]
    
    # 替换为要输入的字符串
    input_string = "aaaaaa"

    run_frida_script(target_process, input_string)
