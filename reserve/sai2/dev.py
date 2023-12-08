import frida
import pprint
import sys
import os

task = True
def on_message(message,data):
    global task
    print("[on_message] message:",message,"data:",data)
    task = False


if __name__ == '__main__':
    target = '.exe'
    rdev =frida.get_local_device()
    pid = rdev.spawn(program=target,stdio='inherit')
    print(pid)
    session = frida.attach(pid)
    jsFile = 'printf.js'
    handle = open(jsFile, "r",encoding='utf-8')
    jsScript = handle.read()
    handle.close()
    script=session.create_script(jsScript)
    script.on("message",on_message)
    script.load()
    rdev.resume(pid)
    while(task):
      pass
    session.detach()
    print('end')