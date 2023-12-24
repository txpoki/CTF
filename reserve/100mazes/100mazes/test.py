from capstone import Cs
from capstone import *
import struct
def decode(offset):
    data_bin = open('100mazes', 'rb').read()
    data = data_bin[offset: offset + 0x199b + 20]
    md = Cs(CS_ARCH_X86, CS_MODE_64)
    inscnt = 0
    inscnt2 = 0
    map1 = []
    map2 = []
    map3 = []
    for i in md.disasm(data, offset):
        ins = "0x%x:\t%s\t%s" % (i.address, i.mnemonic, i.op_str)
        if 'mov	byte ptr [rbp' in ins:
            if inscnt < 629:
                #print(ins)
                map1.append(int(i.op_str.split(', ')[1], 16))
            inscnt += 1

        if 'mov	dword ptr [rbp' in ins:
            if inscnt2 < 2:
                map3.append(int(i.op_str.split(', ')[1], 16))
            inscnt2 += 1

        if 'lea	rax, [rip +' in ins:
            off1 = i.op_str[12:-1]
            off1 = int(off1, 16) + i.address + 7
            map2_data = data_bin[off1: off1 + 4 * 625]
            for i in range(625):
                map2.append(struct.unpack("I", map2_data[i * 4: i * 4 + 4])[0])

    data = []
    for i in range(625):
        data.append(map1[i] ^ map2[i])
    return data, bytearray(map1[-4:]), map3


def checkValid(map, x, y):
    if x < 0 or y < 0 or x > 24 or y > 24:
        return False
    return map[y * 25 + x] == ord('.')


def solve(map, startX, startY, direct, path):
    map[startY * 25 + startX] = ord('*')
    if len(path) == 15:
        return True, path

    all_dir = []
    if checkValid(map, startX, startY - 1):
        all_dir.append((startX, startY - 1, direct[1]))
    if checkValid(map, startX, startY + 1):
        all_dir.append((startX, startY + 1, direct[2]))
    if checkValid(map, startX - 1, startY):
        all_dir.append((startX - 1, startY, direct[3]))
    if checkValid(map, startX + 1, startY):
        all_dir.append((startX + 1, startY, direct[4]))

    for dir in all_dir:
        result = solve(map, dir[0], dir[1], direct, path + dir[2])
        if result[0] == True:
            return result
    return False, ''

def printMap(map):
    for i in range(25):
        line = ''
        for j in range(25):
            line += chr(map1[i * 25 + j])
        print(line)

funcs = """maze_1(void)	.text	000000000000078A	00001AC5	00000C78	00000000	R	.	.	.	.	B	T	.
maze_2(void)	.text	000000000000224F	00001A8F	00000C78	00000000	R	.	.	.	.	B	T	.
maze_3(void)	.text	0000000000003CDE	00001A71	00000C78	00000000	R	.	.	.	.	B	T	.
maze_4(void)	.text	000000000000574F	00001A2F	00000C78	00000000	R	.	.	.	.	B	T	.
maze_5(void)	.text	000000000000717E	00001A53	00000C78	00000000	R	.	.	.	.	B	T	.
maze_6(void)	.text	0000000000008BD1	00001A59	00000C78	00000000	R	.	.	.	.	B	T	.
maze_7(void)	.text	000000000000A62A	00001A2F	00000C78	00000000	R	.	.	.	.	B	T	.
maze_8(void)	.text	000000000000C059	00001B25	00000C78	00000000	R	.	.	.	.	B	T	.
maze_9(void)	.text	000000000000DB7E	00001A23	00000C78	00000000	R	.	.	.	.	B	T	.
maze_10(void)	.text	000000000000F5A1	00001A83	00000C78	00000000	R	.	.	.	.	B	T	.
maze_11(void)	.text	0000000000011024	000019B1	00000C78	00000000	R	.	.	.	.	B	T	.
maze_12(void)	.text	00000000000129D5	00001A47	00000C78	00000000	R	.	.	.	.	B	T	.
maze_13(void)	.text	000000000001441C	00001A83	00000C78	00000000	R	.	.	.	.	B	T	.
maze_14(void)	.text	0000000000015E9F	00001A6B	00000C78	00000000	R	.	.	.	.	B	T	.
maze_15(void)	.text	000000000001790A	00001A7D	00000C78	00000000	R	.	.	.	.	B	T	.
maze_16(void)	.text	0000000000019387	00001AD7	00000C78	00000000	R	.	.	.	.	B	T	.
maze_17(void)	.text	000000000001AE5E	00001A9B	00000C78	00000000	R	.	.	.	.	B	T	.
maze_18(void)	.text	000000000001C8F9	00001AB3	00000C78	00000000	R	.	.	.	.	B	T	.
maze_19(void)	.text	000000000001E3AC	00001AAD	00000C78	00000000	R	.	.	.	.	B	T	.
maze_20(void)	.text	000000000001FE59	00001B2B	00000C78	00000000	R	.	.	.	.	B	T	.
maze_21(void)	.text	0000000000021984	00001A9B	00000C78	00000000	R	.	.	.	.	B	T	.
maze_22(void)	.text	000000000002341F	00001A9B	00000C78	00000000	R	.	.	.	.	B	T	.
maze_23(void)	.text	0000000000024EBA	00001ADD	00000C78	00000000	R	.	.	.	.	B	T	.
maze_24(void)	.text	0000000000026997	00001A59	00000C78	00000000	R	.	.	.	.	B	T	.
maze_25(void)	.text	00000000000283F0	00001A35	00000C78	00000000	R	.	.	.	.	B	T	.
maze_26(void)	.text	0000000000029E25	00001A83	00000C78	00000000	R	.	.	.	.	B	T	.
maze_27(void)	.text	000000000002B8A8	00001A47	00000C78	00000000	R	.	.	.	.	B	T	.
maze_28(void)	.text	000000000002D2EF	00001AB9	00000C78	00000000	R	.	.	.	.	B	T	.
maze_29(void)	.text	000000000002EDA8	00001AB3	00000C78	00000000	R	.	.	.	.	B	T	.
maze_30(void)	.text	000000000003085B	00001AA1	00000C78	00000000	R	.	.	.	.	B	T	.
maze_31(void)	.text	00000000000322FC	00001A89	00000C78	00000000	R	.	.	.	.	B	T	.
maze_32(void)	.text	0000000000033D85	00001A95	00000C78	00000000	R	.	.	.	.	B	T	.
maze_33(void)	.text	000000000003581A	00001A7D	00000C78	00000000	R	.	.	.	.	B	T	.
maze_34(void)	.text	0000000000037297	00001A95	00000C78	00000000	R	.	.	.	.	B	T	.
maze_35(void)	.text	0000000000038D2C	00001A71	00000C78	00000000	R	.	.	.	.	B	T	.
maze_36(void)	.text	000000000003A79D	00001A95	00000C78	00000000	R	.	.	.	.	B	T	.
maze_37(void)	.text	000000000003C232	00001A7D	00000C78	00000000	R	.	.	.	.	B	T	.
maze_38(void)	.text	000000000003DCAF	00001A8F	00000C78	00000000	R	.	.	.	.	B	T	.
maze_39(void)	.text	000000000003F73E	00001A77	00000C78	00000000	R	.	.	.	.	B	T	.
maze_40(void)	.text	00000000000411B5	00001A95	00000C78	00000000	R	.	.	.	.	B	T	.
maze_41(void)	.text	0000000000042C4A	00001AA1	00000C78	00000000	R	.	.	.	.	B	T	.
maze_42(void)	.text	00000000000446EB	00001A53	00000C78	00000000	R	.	.	.	.	B	T	.
maze_43(void)	.text	000000000004613E	00001A95	00000C78	00000000	R	.	.	.	.	B	T	.
maze_44(void)	.text	0000000000047BD3	00001A6B	00000C78	00000000	R	.	.	.	.	B	T	.
maze_45(void)	.text	000000000004963E	00001B4F	00000C78	00000000	R	.	.	.	.	B	T	.
maze_46(void)	.text	000000000004B18D	00001A53	00000C78	00000000	R	.	.	.	.	B	T	.
maze_47(void)	.text	000000000004CBE0	00001A65	00000C78	00000000	R	.	.	.	.	B	T	.
maze_48(void)	.text	000000000004E645	00001A83	00000C78	00000000	R	.	.	.	.	B	T	.
maze_49(void)	.text	00000000000500C8	00001A95	00000C78	00000000	R	.	.	.	.	B	T	.
maze_50(void)	.text	0000000000051B5D	00001B0D	00000C78	00000000	R	.	.	.	.	B	T	.
maze_51(void)	.text	000000000005366A	00001A6B	00000C78	00000000	R	.	.	.	.	B	T	.
maze_52(void)	.text	00000000000550D5	00001ABF	00000C78	00000000	R	.	.	.	.	B	T	.
maze_53(void)	.text	0000000000056B94	00001AE9	00000C78	00000000	R	.	.	.	.	B	T	.
maze_54(void)	.text	000000000005867D	00001A3B	00000C78	00000000	R	.	.	.	.	B	T	.
maze_55(void)	.text	000000000005A0B8	00001A95	00000C78	00000000	R	.	.	.	.	B	T	.
maze_56(void)	.text	000000000005BB4D	00001A59	00000C78	00000000	R	.	.	.	.	B	T	.
maze_57(void)	.text	000000000005D5A6	00001AD1	00000C78	00000000	R	.	.	.	.	B	T	.
maze_58(void)	.text	000000000005F077	00001A71	00000C78	00000000	R	.	.	.	.	B	T	.
maze_59(void)	.text	0000000000060AE8	00001A35	00000C78	00000000	R	.	.	.	.	B	T	.
maze_60(void)	.text	000000000006251D	00001A59	00000C78	00000000	R	.	.	.	.	B	T	.
maze_61(void)	.text	0000000000063F76	00001A4D	00000C78	00000000	R	.	.	.	.	B	T	.
maze_62(void)	.text	00000000000659C3	00001AD7	00000C78	00000000	R	.	.	.	.	B	T	.
maze_63(void)	.text	000000000006749A	00001AD7	00000C78	00000000	R	.	.	.	.	B	T	.
maze_64(void)	.text	0000000000068F71	00001AA1	00000C78	00000000	R	.	.	.	.	B	T	.
maze_65(void)	.text	000000000006AA12	00001AD1	00000C78	00000000	R	.	.	.	.	B	T	.
maze_66(void)	.text	000000000006C4E3	00001B25	00000C78	00000000	R	.	.	.	.	B	T	.
maze_67(void)	.text	000000000006E008	00001A95	00000C78	00000000	R	.	.	.	.	B	T	.
maze_68(void)	.text	000000000006FA9D	00001A71	00000C78	00000000	R	.	.	.	.	B	T	.
maze_69(void)	.text	000000000007150E	00001AD7	00000C78	00000000	R	.	.	.	.	B	T	.
maze_70(void)	.text	0000000000072FE5	00001A71	00000C78	00000000	R	.	.	.	.	B	T	.
maze_71(void)	.text	0000000000074A56	00001AD7	00000C78	00000000	R	.	.	.	.	B	T	.
maze_72(void)	.text	000000000007652D	00001AF5	00000C78	00000000	R	.	.	.	.	B	T	.
maze_73(void)	.text	0000000000078022	00001AFB	00000C78	00000000	R	.	.	.	.	B	T	.
maze_74(void)	.text	0000000000079B1D	00001AB9	00000C78	00000000	R	.	.	.	.	B	T	.
maze_75(void)	.text	000000000007B5D6	00001AB9	00000C78	00000000	R	.	.	.	.	B	T	.
maze_76(void)	.text	000000000007D08F	00001AF5	00000C78	00000000	R	.	.	.	.	B	T	.
maze_77(void)	.text	000000000007EB84	00001A47	00000C78	00000000	R	.	.	.	.	B	T	.
maze_78(void)	.text	00000000000805CB	000019FF	00000C78	00000000	R	.	.	.	.	B	T	.
maze_79(void)	.text	0000000000081FCA	00001AF5	00000C78	00000000	R	.	.	.	.	B	T	.
maze_80(void)	.text	0000000000083ABF	00001ACB	00000C78	00000000	R	.	.	.	.	B	T	.
maze_81(void)	.text	000000000008558A	00001A8F	00000C78	00000000	R	.	.	.	.	B	T	.
maze_82(void)	.text	0000000000087019	00001AAD	00000C78	00000000	R	.	.	.	.	B	T	.
maze_83(void)	.text	0000000000088AC6	00001ABF	00000C78	00000000	R	.	.	.	.	B	T	.
maze_84(void)	.text	000000000008A585	00001A3B	00000C78	00000000	R	.	.	.	.	B	T	.
maze_85(void)	.text	000000000008BFC0	00001A77	00000C78	00000000	R	.	.	.	.	B	T	.
maze_86(void)	.text	000000000008DA37	00001AD1	00000C78	00000000	R	.	.	.	.	B	T	.
maze_87(void)	.text	000000000008F508	00001ACB	00000C78	00000000	R	.	.	.	.	B	T	.
maze_88(void)	.text	0000000000090FD3	00001A95	00000C78	00000000	R	.	.	.	.	B	T	.
maze_89(void)	.text	0000000000092A68	00001B0D	00000C78	00000000	R	.	.	.	.	B	T	.
maze_90(void)	.text	0000000000094575	00001ABF	00000C78	00000000	R	.	.	.	.	B	T	.
maze_91(void)	.text	0000000000096034	00001A71	00000C78	00000000	R	.	.	.	.	B	T	.
maze_92(void)	.text	0000000000097AA5	00001ACB	00000C78	00000000	R	.	.	.	.	B	T	.
maze_93(void)	.text	0000000000099570	00001A11	00000C78	00000000	R	.	.	.	.	B	T	.
maze_94(void)	.text	000000000009AF81	00001A9B	00000C78	00000000	R	.	.	.	.	B	T	.
maze_95(void)	.text	000000000009CA1C	00001B07	00000C78	00000000	R	.	.	.	.	B	T	.
maze_96(void)	.text	000000000009E523	00001A95	00000C78	00000000	R	.	.	.	.	B	T	.
maze_97(void)	.text	000000000009FFB8	00001AAD	00000C78	00000000	R	.	.	.	.	B	T	.
maze_98(void)	.text	00000000000A1A65	00001AF5	00000C78	00000000	R	.	.	.	.	B	T	.
maze_99(void)	.text	00000000000A355A	00001B1F	00000C78	00000000	R	.	.	.	.	B	T	.
maze_100(void)	.text	00000000000A5079	00001A2F	00000C78	00000000	R	.	.	.	.	B	T	."""

total = ''
for ll in funcs.splitlines():
    ll = ll.split("	")
    addr = int(ll[2], 16)
    map1, dirs, target = decode(addr)
    print("process:" + hex(addr))
    rr = solve(map1, target[0], target[1], 'A' + dirs.decode('utf-8'), '')
    total += rr[1]


import hashlib
mm = hashlib.md5(total.encode('utf-8')).hexdigest()

print(total)
print(len(total))
d = mm
print("flag{%s-%s-%s-%s-%s}" % (d[0:8],d[8:12],d[12:16],d[16:20],d[20:32]))