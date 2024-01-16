// frida_script.js
var targetFunctionAddr = Module.findExportByName(null, 'sub_1400B7E04');  // 替换为你要监视的目标函数的名称或地址

Interceptor.attach(targetFunctionAddr, {
    onLeave: function(retval) {
        var returnValue = retval.toInt32();  // 根据返回值类型调整
        if (returnValue === 1) {
            console.log("Success detected!");
            // 在这里可以触发一些操作，例如停止目标程序
            // 也可以通过 send 函数发送消息给 Python 脚本，然后 Python 脚本停止爆破过程
            send({ success: true, input: Memory.readUtf8String(ptr(your_input_address), input_length) });
        }
    }
});
