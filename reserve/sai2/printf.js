function anti_check(){
     var target = 'sai2.exe';
     var offset = 0x14005FD18;
     var libNative = TraverseModules('single', {name: target});
     var addr = libNative.base.add(offset);
     Interceptor.attach(addr,{
        onEnter: function(args) {
            console.log('check')
        },
        onLeave: function(retval) {
            retval.replace(219)
        }}
      )
 }

 function hook_exit(){
    var target = 'sai2.exe';
    var offset = 0x7D1F;
    var libNative = TraverseModules('single', {name: target});
    var addr = libNative.base.add(offset);
    Interceptor.attach(addr,{
       onEnter: function(args) {
           console.log('WinMain Call')
       },
       onLeave: function(retval) {
        console.log('WinMain Ret');
        send('exit');
       }}
     )
 }

 function hook_send(){
  
  var target = 'sai2.exe';
  var offset = 0x6933;
  var libNative = TraverseModules('single', {name: target});
  var addr = libNative.base.add(offset);
  function replacementFunction() {
    console.log('Bypass netCheck');
    return 0xF;
  }
  var replacement = new NativeCallback(replacementFunction, 'int', []);
  Interceptor.replace(addr,replacement);
 }
 function  main(){
    anti_check();
    hook_exit();
    hook_send();

 }

 function TraverseModules(mode, {name = '', name_array = []}) {
     if (mode == 'all') {
       var modules = Process.enumerateModules();
       for (var i = 0; i < modules.length; i++) {
         var module = modules[i];
         // LogModule(module);
       }
       return modules;
     } else if (mode == 'single') {
       var module = Process.getModuleByName(name);
       LogModule(module);
       return module;
     } else if (mode == 'multiple') {
       var modules = Process.enumerateModules();
       var target_modules = [];
       for (var i = 0; i < modules.length; i++) {
         var module = modules[i];
         if (name_array.indexOf(module.name) != -1) {
           LogModule(module);
           target_modules.push(module);
         }
       }
       return target_modules;
     }
   }
 function LogModule(module) {
     console.log('Module name: ' + module.name);
     console.log('Module base: ' + module.base);
     console.log('Module size: ' + module.size);
 }
 main();