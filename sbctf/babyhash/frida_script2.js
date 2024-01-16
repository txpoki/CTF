// frida_script.js

// 1. 读取输入字符串
var inputString = Frida.recv('input_string');

// 2. 向目标进程的标准输入流写入字符串
var stdinWrite = new NativeFunction(Module.findExportByName(null, 'write'), 'ssize_t', ['int', 'pointer', 'size_t']);
var inputBuffer = Memory.allocUtf8String(inputString);
stdinWrite(0, inputBuffer, inputString.length);

// 3. Hook 输入函数并监测返回值
var targetFunctionAddr = ptr('0x1400B7E04')
Interceptor.attach(targetFunctionAddr, {
    onLeave: function(retval) {
        console.log("[*] Input function returned:", retval);

        // 4. 判断返回值是否符合预期
        if (retval.toInt32() === 1) {
            console.log("[*] Success detected!");

            // 5. 向 Python 脚本发送成功消息
            send({ success: true, input: inputString });

            // 在这里添加停止爆破过程的逻辑
            Process.exit(0);
        } else {
            console.log("[*] Restarting the program...");
            
            // 6. 向 Python 脚本发送失败消息
            send({ success: false });

            // 7. 重新启动程序
            Process.exec('your_target_program');
        }
    }
});
