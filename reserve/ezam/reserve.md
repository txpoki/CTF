1. 函数的开始地址为序言的地址
2. 序言的后继为主分发器
3. 后继为主分发器的块为预处理器
4. 后继为预处理器的块为真实块
5. 无后继的块为retn块
6. 剩下的为无用块