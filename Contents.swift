import UIKit
//1
let s1="China"
let s2="MyLove"
let s3=s1+s2
for s in s3{
    if s=="L"
    {print(s)}
}

//2
var str = "swift!Lorem ipsum?202210!!你好!砸哇路多?"
let target:Set<Character>=["!","?"]
str.removeAll(where: {target.contains($0)})
print(str)

//3
let s4 = "Crazy Thursday V me 50."
let s4s = String(s4.reversed())
print(s4s)

//4
var s5="疯狂星期四薇我五十"
let count = s5.count
var i=1
while i<count*2{
    s5.insert("*", at: s5.index(s5.startIndex,offsetBy:i))
    i=i+2
}
print(s5)

//5
var s6="aaa随便吧aaa我只想~睡觉aaa我有空就睡觉aaa"
var s7=s6.replacingOccurrences(of: "aaa", with: "hi")
print(s7)
