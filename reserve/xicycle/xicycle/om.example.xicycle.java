package com.example.xicycle;

import android.content.Context;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;
import java.nio.ByteBuffer;
import java.util.Arrays;
import p021f.ActivityC0793h;

/* loaded from: classes.dex */
public class MainActivity extends ActivityC0793h {
    /* renamed from: s */
    public static int m1548s(int i, int i2) {
        return (i + i2) & 65535;
    }

    /* renamed from: t */
    public static int m1547t(int i, int i2) {
        long j = i * i2;
        return (j != 0 ? (int) (j % 65537) : (1 - i) - i2) & 65535;
    }

    public void check(View view) {
        int i;
        Context applicationContext;
        String str;
        String obj = ((EditText) findViewById(R.id.editTextTextPassword)).getText().toString();
        if (obj.length() == 32) {
            byte[] bytes = obj.getBytes();
            int[] iArr = {12643, 25650, 12644, 13156, 13619, 25136, 13414, 14691, 25698, 51302, 51306, 26308, 24680, 52338, 50786, 50888, 52624, 54477, 35008, 53656, 58764, 50573, 37064, 50576, 39697, 33187, 12747, 6539, 6945, 37259, 8603, 8617, 18019, 38451, 5686, 17187, 5699, 13891, 21302, 8963, 26156, 27782, 17964, 34412, 34470, 27718, 1676, 50988, 3212, 22796, 55565, 19672, 16582, 28874, 19287, 56017};
            int i2 = 0;
            int i3 = 0;
            for (int i4 = 0; i4 < bytes.length; i4 += 8) {
                int i5 = i4 + 0;
                int i6 = i4 + 1;
                int inp12 = ((bytes[i5] & 255) << 8) | (bytes[i6] & 255);
                int i7 = i4 + 2;
                int i8 = i4 + 3;
                int inp34 = ((bytes[i7] & 255) << 8) | (bytes[i8] & 255);
                int i9 = i4 + 4;
                int i10 = i4 + 5;
                int inp56 = (bytes[i10] & 255) | ((bytes[i9] & 255) << 8);
                int i11 = i4 + 6;
                int i12 = i4 + 7;
                int inp78 = ((bytes[i11] & 255) << 8) | (bytes[i12] & 255);
                int i13 = 0;
                int i14 = 0;
                for (int i15 = 8; i13 < i15; i15 = 8) {
                    int i16 = i14 + 1;
                    int t = m1547t(inp12, iArr[i14]); // 0
                    int i17 = i16 + 1;
                    int s = m1548s(inp34, iArr[i16]); // 1
                    int i18 = i17 + 1;
                    int s2 = m1548s(inp56, iArr[i17]); // 2
                    int i19 = i18 + 1;
                    int t2 = m1547t(inp78, iArr[i18]); // 3
                    int i20 = i19 + 1;
                    int t3 = m1547t(t ^ s2, iArr[i19]); // 4_
                    i14 = i20 + 1;
                    int t4 = m1547t(m1548s(s ^ t2, t3), iArr[i20]);
                    int s3 = m1548s(t3, t4);
                    inp12 = t ^ t4;
                    inp34 = s2 ^ t4;
                    inp56 = s ^ s3;
                    inp78 = t2 ^ s3;
                    i13++;
                }
                int i21 = i3;
                int i22 = i14 + 1;
                int t5 = m1547t(inp12, iArr[i14]);
                int i23 = i22 + 1;
                int s4 = m1548s(inp56, iArr[i22]);
                int i24 = i23 + 1;
                int s5 = m1548s(inp34, iArr[i23]);
                int t6 = m1547t(inp78, iArr[i24]);
 
                if (i4 >= 20) { 
                    int length = bytes.length / 4;
                    int[] iArr2 = new int[length];
                    int i25 = 0;
                    int i26 = 0;
                    //小端8字节
                    while (i25 < length) {
                        iArr2[i25] = ((bytes[i26 + 2] & 255) << 8) | (bytes[i26 + 3] & 255) | ((bytes[i26 + 1] & 255) << 16) | ((bytes[i26 + 0] & 255) << 24);
                        i26 += 4;
                        i25++;
                    }
                    int i27 = (i4 / 4) - 2;
                    int i28 = i27 + 1;
                    int i29 = iArr2[i28];
         // TEA 当第三，第四论进行
                    for (int i30 = 0; i30 < 32; i30++) {
                        int i31 = 1;
                        while (i31 > 0) {
                            int i32 = (i2 >>> 2) & 3;
                            int i33 = 1;
                            while (i33 > 0) {
                                int i34 = i27 + i33;
                                int i35 = iArr2[i34 - 1];
                                i21 = iArr2[i34] - ((((i35 >>> 5) ^ (i21 << 2)) + ((i21 >>> 3) ^ (i35 << 4))) ^ ((i2 ^ i21) + (iArr2[(i33 & 3) ^ i32] ^ i35)));
                                iArr2[i34] = i21;
                                i33--;
                            }
                            int i36 = iArr2[i28];
                            i21 = iArr2[i27] - ((((i36 >>> 5) ^ (i21 << 2)) + ((i21 >>> 3) ^ (i36 << 4))) ^ ((i2 ^ i21) + (iArr2[(i33 & 3) ^ i32] ^ i36)));
                            iArr2[i27] = i21;
                            i2 -= -158018577;
                            i31 = i33 - 1;
                        }
                    }
                    ByteBuffer allocate = ByteBuffer.allocate(length * 4);
                    allocate.asIntBuffer().put(iArr2);
                    bytes = allocate.array();
                } else {
                }
        //重新赋值,赋(判断TEA)之前的值
                bytes[i5] = (byte) (t5 >> 8);
                bytes[i6] = (byte) t5;
                bytes[i7] = (byte) (s4 >> 8);
                bytes[i8] = (byte) s4;
                bytes[i9] = (byte) (s5 >> 8);
                bytes[i10] = (byte) s5;
                bytes[i11] = (byte) (t6 >> 8);
                bytes[i12] = (byte) t6;
                int length2 = bytes.length / 4;
                int[] iArr3 = new int[length2];
                int i37 = 0;
                //小端8字节
                for (int i38 = 0; i38 < length2; i38++) {
                    iArr3[i38] = (bytes[i37 + 3] & 255) | ((bytes[i37 + 2] & 255) << 8) | ((bytes[i37 + 1] & 255) << 16) | ((bytes[i37 + 0] & 255) << 24);
                    i37 += 4;
                }
        // TEA
                int i4_n = i4 / 4;
                i3 = iArr3[i4_n]; 
                i2 = -1681272913;
                for (int i40 = 0; i40 < 33; i40++) {
                    int dn = (i2 >>> 2) & 3;
                    int i42 = 1;
                    while (i42 > 0) {
                        int i43 = i4_n + i42;
                        int i44 = iArr3[i43 - 1];
                        if (i4 < 12) {
                            i3 = ((i3 ^ i2) + (iArr3[(i42 & 3) ^ dn] ^ i44)) ^ ((iArr3[i43] - ((i44 >>> 5) ^ (i3 << 2))) + ((i3 >>> 3) ^ (i44 << 4)));
                        } else {
                            int i45 = iArr3[i43] - (((i3 ^ i2) + (i44 ^ iArr3[(i42 & 3) ^ dn])) ^ (((i44 >>> 5) ^ (i3 << 2)) + ((i3 >>> 3) ^ (i44 << 4))));
                            iArr3[i43] = i45;
                            i3 = i45;
                        }
                        i42--;
                    }
                    int i46 = iArr3[i4_n + 1];
                    if (i4 < 12) {
                        i3 = ((i3 ^ i2) + (iArr3[dn ^ (i42 & 3)] ^ i46)) ^ ((iArr3[i4_n] - ((i46 >>> 5) ^ (i3 << 2))) + ((i3 >>> 3) ^ (i46 << 4)));
                    } else {
                        int i47 = iArr3[i4_n] - (((i3 ^ i2) + (iArr3[dn ^ (i42 & 3)] ^ i46)) ^ (((i46 >>> 5) ^ (i3 << 2)) + ((i3 >>> 3) ^ (i46 << 4))));
                        iArr3[i4_n] = i47;
                        i3 = i47;
                    }
                    i2 -= -158018577;
                }
                ByteBuffer allocate2 = ByteBuffer.allocate(length2 * 4);
                allocate2.asIntBuffer().put(iArr3);
                bytes = allocate2.array();
            }
            if (Arrays.equals(bytes, new byte[]{-26, -87, 15, -85, 76, 15, -107, -95, -72, -59, -60, 101, -80, -15, 117, 117, -58, -76, 60, 69, 53, -4, 123, -36, -45, -104, 98, -127, -63, 16, 83, -124})) {
                applicationContext = getApplicationContext();
                str = "right";
                i = 0;
                Toast.makeText(applicationContext, str, i).show();
            }
        }
        i = 0;
        applicationContext = getApplicationContext();
        str = "wrong";
        Toast.makeText(applicationContext, str, i).show();
    }

    @Override // p070u0.ActivityC1311f, androidx.activity.ComponentActivity, p081y.ActivityC1417f, android.app.Activity
    public void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        setContentView(R.layout.activity_main);
    }
}