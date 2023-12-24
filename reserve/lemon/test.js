var a = [65, 69, 83];
var b = [113, 105, 117, 113, 105, 117, 108, 101, 98, 105, 101, 122, 117, 111, 108, 101];
var c = 0;
var d = [];
while (c < 256){
  d.push(c); // 将append改为push
  c = c + 1;
};
var e = 0;
while (e < 256) {
  d[e] = (d[e] + a[e % 3] + b[e % 16]) % 256;
  e += 1;
};
var f = 0;
while (f < 3) {
  var g = 0;
  while (g < 256) {
    d[g] = d[g] ^ d[(g + 1) % 256];
    g = g + 1;
  };
  var h = 0;
  while (h < 256) {
    d[h] = ((d[h] + 1) % 256 + 256) % 256; // 将取余运算的结果调整为非负数
    h = h + 1;
  };
  f = f + 1;
};
f = 0;
var i = 0;
while (f < 256) {
  i = i + d[f];
  f = f + 1;
};
i = i * 20 + 5;
i = i * 30 - 5;
i = i * 40 - 5;
i = i * 50 + 6645;
console.log(i); // 将print改为console.log
