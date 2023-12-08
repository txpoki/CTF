import requests
s = requests.Session()
data = {"answer":1} 
response1 = s.request("INPUT", "http://scr1w.dlut.edu.cn:28087/ezmath_problem/post?answer=1", data)
text2=response1.text
print(text2)