import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.PrintStream;
import java.io.Reader;
import java.util.Arrays;

public class Simple extends Object {

    public Simple() {
        super();
        this.init();
    }

    private void init() {
        super();
        specialinvoke(this.<Object>init());
        return;
    }

    private static int[] method1(byte[] paramArrayOfByte) {
        byte[] arrayOfByte = paramArrayOfByte;
        int i = lengthof(arrayOfByte);
        int j = i >> 2;
        int[] arrayOfInt = newarray(int, j);
        int k = 0;
        int m = 0;
        label1:
        int n = lengthof(arrayOfByte);
        if (m >= n) goto label2;
        int i1 = m + 3;
        byte b1 = arrayOfByte[i1];
        int i2 = method4(b1);
        int i3 = m + 2;
        byte b2 = arrayOfByte[i3];
        int i4 = method4(b2);
        int i5 = i4 << 8;
        int i6 = i2 | i5;
        int i7 = m + 1;
        byte b3 = arrayOfByte[i7];
        int i8 = method4(b3);
        int i9 = i8 << 16;
        int i10 = i6 | i9;
        byte b4 = arrayOfByte[m];
        int i11 = b4 << 24;
        int i12 = i10 | i11;
        arrayOfInt[k] = i12;
        k = k + 1;
        m = m + 4;
        goto label1;
        label2:
        return arrayOfInt;
    }

    private static byte[] method2(int[] paramArrayOfInt) {
        int[] arrayOfInt = paramArrayOfInt;
        int i = lengthof(arrayOfInt);
        int j = i << 2;
        byte[] arrayOfByte = newarray(byte, j);
        int k = 0;
        int m = 0;
        label1:
        int n = lengthof(arrayOfByte);
        if (m >= n) goto label2;
        int i1 = m + 3;
        int i2 = arrayOfInt[k];
        int i3 = i2 & 255;
        byte b1 = (byte)i3;
        arrayOfByte[i1] = b1;
        int i4 = m + 2;
        int i5 = arrayOfInt[k];
        int i6 = i5 >> 8;
        int i7 = i6 & 255;
        byte b2 = (byte)i7;
        arrayOfByte[i4] = b2;
        int i8 = m + 1;
        int i9 = arrayOfInt[k];
        int i10 = i9 >> 16;
        int i11 = i10 & 255;
        byte b3 = (byte)i11;
        arrayOfByte[i8] = b3;
        int i12 = arrayOfInt[k];
        int i13 = i12 >> 24;
        int i14 = i13 & 255;
        byte b4 = (byte)i14;
        arrayOfByte[m] = b4;
        k = k + 1;
        m = m + 4;
        goto label1;
        label2:
        return arrayOfByte;
    }

    public static byte[] method3(byte[] paramArrayOfByte, int[] paramArrayOfInt) {
        byte[] arrayOfByte1 = paramArrayOfByte;
        int[] arrayOfInt = paramArrayOfInt;
        int[] arrayOfInt1 = method1(arrayOfByte1);
        int i = 0;
        label1:
        int j = lengthof(arrayOfInt1);
        if (i >= j) goto label4;
        int k = arrayOfInt1[i];
        int m = i + 1;
        int n = arrayOfInt1[m];
        int i1 = 0;
        int i2 = 0;
        label2:
        if (i2 >= 32) goto label3;
        i1 = i1 + -1640531527;
        int i3 = n << 4;
        int i4 = arrayOfInt[0];
        int i5 = i3 + i4;
        int i6 = n + i1;
        int i7 = i5 ^ i6;
        int i8 = n >> 5;
        int i9 = arrayOfInt[1];
        int i10 = i8 + i9;
        int i11 = i7 ^ i10;
        k = k + i11;
        int i12 = k << 4;
        int i13 = arrayOfInt[2];
        int i14 = i12 + i13;
        int i15 = k + i1;
        int i16 = i14 ^ i15;
        int i17 = k >> 5;
        int i18 = arrayOfInt[3];
        int i19 = i17 + i18;
        int i20 = i16 ^ i19;
        n = n + i20;
        i2 = i2 + 1;
        goto label2;
        label3:
        arrayOfInt1[i] = k;
        int i21 = i + 1;
        arrayOfInt1[i21] = n;
        i = i + 2;
        goto label1;
        label4:
        byte[] arrayOfByte2 = method2(arrayOfInt1);
        return arrayOfByte2;
    }

    private static int method4(byte paramByte) {
        byte b = paramByte;
        int i = b;
        if (b < 0) {
            i = b + 256;
        }
        return i;
    }

    public static void main(String[] paramArrayOfString) {
        int[] arrayOfInt;
        PrintStream localPrintStream1;
        PrintStream localPrintStream2;
        BufferedReader localBufferedReader;
        InputStreamReader localInputStreamReader;
        InputStream localInputStream;
        String str1;
        byte[] arrayOfByte1;
        byte[] arrayOfByte2;
        boolean bool;
        IOException localIOException;
        RuntimeException localRuntimeException;
        String[] arrayOfString;

        arrayOfString = paramArrayOfString;
        arrayOfInt = newarray(int, 4);
        arrayOfInt[0] = 1732584193;
        arrayOfInt[1] = -271733879;
        arrayOfInt[2] = -1732584194;
        arrayOfInt[3] = 271733878;
        localPrintStream1 = System.out;
        virtualinvoke(localPrintStream1.println("please input your flag:"));
        localBufferedReader = new BufferedReader;
        localInputStreamReader = new InputStreamReader;
        localInputStream = System.in;
        specialinvoke(localInputStreamReader.<init>(localInputStream));
        specialinvoke(localBufferedReader.<init>(localInputStreamReader));
        label1:
        str1 = virtualinvoke(localBufferedReader.readLine());
        arrayOfByte1 = virtualinvoke(str1.getBytes());
        arrayOfByte2 = newarray(byte, 24);
        arrayOfByte2[0] = 73;
        arrayOfByte2[1] = -65;
        arrayOfByte2[2] = 27;
        arrayOfByte2[3] = -19;
        arrayOfByte2[4] = -77;
        arrayOfByte2[5] = 28;
        arrayOfByte2[6] = 108;
        arrayOfByte2[7] = 82;
        arrayOfByte2[8] = 43;
        arrayOfByte2[9] = 60;
        arrayOfByte2[10] = -14;
        arrayOfByte2[11] = 58;
        arrayOfByte2[12] = 28;
        arrayOfByte2[13] = 44;
        arrayOfByte2[14] = -21;
        arrayOfByte2[15] = 77;
        arrayOfByte2[16] = 31;
        arrayOfByte2[17] = 114;
        arrayOfByte2[18] = 43;
        arrayOfByte2[19] = 98;
        arrayOfByte2[20] = 88;
        arrayOfByte2[21] = 17;
        arrayOfByte2[22] = 23;
        arrayOfByte2[23] = -9;
        bool = virtualinvoke(Arrays.equals(arrayOfByte2, method3(arrayOfByte1, arrayOfInt)));
        if (bool == false) goto label2;
        localPrintStream2 = System.out;
        virtualinvoke(localPrintStream2.println("right flag!"));
        goto label3;
        label2:
        localPrintStream2 = System.out;
        virtualinvoke(localPrintStream2.println("wrong flag!"));
        label3:
        goto label5;
        label4:
        localIOException = caughtexception;
        localRuntimeException = new RuntimeException;
        specialinvoke(localRuntimeException.<init>(localIOException));
        throw localRuntimeException;
        label5:
        return;
        catch (IOException localIOException) from label1 to label3 with label4;
    }
}
