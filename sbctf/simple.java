public class simple extends java.lang.Object
{

    public void <init>()
    {
        simple r0;

        r0 := @this: simple;

        specialinvoke r0.<java.lang.Object: void <init>()>();

        return;
    }

    private static int[] method1(byte[])
    {
        byte[] r0;
        int $i0, $i1, $i2, $i3, $i5, $i6, $i8, $i9, $i10, $i12, $i13, $i14, $i16, $i17, $i18, i19, i20;
        int[] r1;
        byte $b4, $b7, $b11, $b15;

        r0 := @parameter0: byte[];

        $i0 = lengthof r0;

        $i1 = $i0 >> 2;

        r1 = newarray (int)[$i1];

        i19 = 0;

        i20 = 0;

     label1:
        $i2 = lengthof r0;

        if i20 >= $i2 goto label2;

        $i3 = i20 + 3;

        $b4 = r0[$i3];

        $i5 = staticinvoke <simple: int method4(byte)>($b4);

        $i6 = i20 + 2;

        $b7 = r0[$i6];

        $i8 = staticinvoke <simple: int method4(byte)>($b7);

        $i9 = $i8 << 8;

        $i12 = $i5 | $i9;

        $i10 = i20 + 1;

        $b11 = r0[$i10];

        $i13 = staticinvoke <simple: int method4(byte)>($b11);

        $i14 = $i13 << 16;

        $i17 = $i12 | $i14;

        $b15 = r0[i20];

        $i16 = $b15 << 24;

        $i18 = $i17 | $i16;

        r1[i19] = $i18;

        i19 = i19 + 1;

        i20 = i20 + 4;

        goto label1;

     label2:
        return r1;
    }

    private static byte[] method2(int[])
    {
        int[] r0;
        int $i0, $i1, $i2, $i3, $i4, $i6, $i7, $i8, $i9, $i11, $i12, $i13, $i14, $i16, $i17, $i18, $i19, i21, i22;
        byte[] r1;
        byte $b5, $b10, $b15, $b20;

        r0 := @parameter0: int[];

        $i0 = lengthof r0;

        $i1 = $i0 << 2;

        r1 = newarray (byte)[$i1];

        i21 = 0;

        i22 = 0;

     label1:
        $i2 = lengthof r1;

        if i22 >= $i2 goto label2;

        $i6 = i22 + 3;

        $i3 = r0[i21];

        $i4 = $i3 & 255;

        $b5 = (byte) $i4;

        r1[$i6] = $b5;

        $i11 = i22 + 2;

        $i7 = r0[i21];

        $i8 = $i7 >> 8;

        $i9 = $i8 & 255;

        $b10 = (byte) $i9;

        r1[$i11] = $b10;

        $i16 = i22 + 1;

        $i12 = r0[i21];

        $i13 = $i12 >> 16;

        $i14 = $i13 & 255;

        $b15 = (byte) $i14;

        r1[$i16] = $b15;

        $i17 = r0[i21];

        $i18 = $i17 >> 24;

        $i19 = $i18 & 255;

        $b20 = (byte) $i19;

        r1[i22] = $b20;

        i21 = i21 + 1;

        i22 = i22 + 4;

        goto label1;

     label2:
        return r1;
    }

    public static byte[] method3(byte[], int[])
    {
        byte[] r0, $r2;
        int[] r1, r3;
        int $i0, $i1, $i4, $i5, $i6, $i7, $i8, $i9, $i10, $i11, $i12, $i13, $i14, $i15, $i16, $i17, $i18, $i19, $i20, $i21, $i22, i23, i24, i25, i26, i27;

        r0 := @parameter0: byte[];

        r3 := @parameter1: int[];

        r1 = staticinvoke <simple: int[] method1(byte[])>(r0);

        i23 = 0;

     label1:
        $i0 = lengthof r1;

        if i23 >= $i0 goto label4;

        i24 = r1[i23];

        $i1 = i23 + 1;

        i25 = r1[$i1];

        i26 = 0;

        i27 = 0;

     label2:
        if i27 >= 32 goto label3;

        i26 = i26 + -1640531527;

        $i6 = i25 << 4;

        $i5 = r3[0];

        $i8 = $i6 + $i5;

        $i7 = i25 + i26;

        $i12 = $i8 ^ $i7;

        $i10 = i25 >> 5;

        $i9 = r3[1];

        $i11 = $i10 + $i9;

        $i13 = $i12 ^ $i11;

        i24 = i24 + $i13;

        $i15 = i24 << 4;

        $i14 = r3[2];

        $i17 = $i15 + $i14;

        $i16 = i24 + i26;

        $i21 = $i17 ^ $i16;

        $i19 = i24 >> 5;

        $i18 = r3[3];

        $i20 = $i19 + $i18;

        $i22 = $i21 ^ $i20;

        i25 = i25 + $i22;

        i27 = i27 + 1;

        goto label2;

     label3:
        r1[i23] = i24;

        $i4 = i23 + 1;

        r1[$i4] = i25;

        i23 = i23 + 2;

        goto label1;

     label4:
        $r2 = staticinvoke <simple: byte[] method2(int[])>(r1);

        return $r2;
    }

    private static int method4(byte)
    {
        byte b0;
        int i1;

        b0 := @parameter0: byte;

        i1 = b0;

        if b0 >= 0 goto label1;

        i1 = b0 + 256;

     label1:
        return i1;
    }

    public static void main(java.lang.String[])
    {
        int[] $r0;
        java.io.PrintStream $r2, $r11, $r12;
        java.io.BufferedReader $r3;
        java.io.InputStreamReader $r4;
        java.io.InputStream $r5;
        java.lang.String $r7;
        byte[] $r8, r10, r16;
        boolean $z0;
        java.io.IOException $r13;
        java.lang.RuntimeException $r14;
        java.lang.String[] r15;

        r15 := @parameter0: java.lang.String[];

        $r0 = newarray (int)[4];

        $r0[0] = 1732584193;

        $r0[1] = -271733879;

        $r0[2] = -1732584194;

        $r0[3] = 271733878;

        $r2 = <java.lang.System: java.io.PrintStream out>;

        virtualinvoke $r2.<java.io.PrintStream: void println(java.lang.String)>("please input your flag:");

        $r3 = new java.io.BufferedReader;

        $r4 = new java.io.InputStreamReader;

        $r5 = <java.lang.System: java.io.InputStream in>;

        specialinvoke $r4.<java.io.InputStreamReader: void <init>(java.io.InputStream)>($r5);

        specialinvoke $r3.<java.io.BufferedReader: void <init>(java.io.Reader)>($r4);

     label1:
        $r7 = virtualinvoke $r3.<java.io.BufferedReader: java.lang.String readLine()>();

        r16 = virtualinvoke $r7.<java.lang.String: byte[] getBytes()>();

        $r8 = newarray (byte)[24];

        $r8[0] = 73;

        $r8[1] = -65;

        $r8[2] = 27;

        $r8[3] = -19;

        $r8[4] = -77;

        $r8[5] = 28;

        $r8[6] = 108;

        $r8[7] = 82;

        $r8[8] = 43;

        $r8[9] = 60;

        $r8[10] = -14;

        $r8[11] = 58;

        $r8[12] = 28;

        $r8[13] = 44;

        $r8[14] = -21;

        $r8[15] = 77;

        $r8[16] = 31;

        $r8[17] = 114;

        $r8[18] = 43;

        $r8[19] = 98;

        $r8[20] = 88;

        $r8[21] = 17;

        $r8[22] = 23;

        $r8[23] = -9;

        r10 = staticinvoke <simple: byte[] method3(byte[],int[])>(r16, $r0);

        $z0 = staticinvoke <java.util.Arrays: boolean equals(byte[],byte[])>(r10, $r8);

        if $z0 == 0 goto label2;

        $r12 = <java.lang.System: java.io.PrintStream out>;

        virtualinvoke $r12.<java.io.PrintStream: void println(java.lang.String)>("right flag!");

        goto label3;

     label2:
        $r11 = <java.lang.System: java.io.PrintStream out>;

        virtualinvoke $r11.<java.io.PrintStream: void println(java.lang.String)>("wrong flag!");

     label3:
        goto label5;

     label4:
        $r13 := @caughtexception;

        $r14 = new java.lang.RuntimeException;

        specialinvoke $r14.<java.lang.RuntimeException: void <init>(java.lang.Throwable)>($r13);

        throw $r14;

     label5:
        return;

        catch java.io.IOException from label1 to label3 with label4;
    }
}
