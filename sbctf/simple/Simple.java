import java.io.*;
import java.util.Arrays;

public class Simple {

    private static int[] method1(byte[] r0) {
        int[] r1 = new int[r0.length / 4];
        int i = 0, j = 0;

        while (j < r0.length) {
            r1[i] = (r0[j + 3] & 0xFF) | ((r0[j + 2] & 0xFF) << 8) | ((r0[j + 1] & 0xFF) << 16) | (r0[j] << 24);
            i++;
            j += 4;
        }

        return r1;
    }

    private static byte[] method2(int[] r0) {
        byte[] r1 = new byte[r0.length * 4];
        int i = 0, j = 0;

        while (j < r1.length) {
            r1[j + 3] = (byte) r0[i];
            r1[j + 2] = (byte) (r0[i] >> 8);
            r1[j + 1] = (byte) (r0[i] >> 16);
            r1[j] = (byte) (r0[i] >> 24);
            i++;
            j += 4;
        }

        return r1;
    }

    public static byte[] method3(byte[] r0, int[] r3) {
        int[] r1 = method1(r0);
        int i = 0;

        while (i < r1.length) {
            int j = 0;
            int k = 0;

            while (j < 32) {
                k -= 1640531527;
                
                int m = (r1[i + 1] << 4) + r3[0];
                int n = (r1[i+1] + k) ^ m;
                int o = (r1[i+1] >> 5) + r3[1];
                int p = n ^ o;
                r1[i] += p;
                int q = (r1[i] << 4) + r3[2];
                int r = (r1[i] + k) ^ q;
                int s = (r1[i] >> 5) + r3[3];
                int t = r ^ s;
                r1[i + 1] += t;
                j++;
                System.out.println(k+);
            }

            i += 2;
        }

        return method2(r1);
    }

    private static int method4(byte b0) {
        return (b0 < 0) ? b0 + 256 : b0;
    }

    public static void main(String[] r15) {
        int[] $r0 = { 1732584193, -271733879, -1732584194, 271733878 };

        try {
            System.out.println("please input your flag:");
            BufferedReader $r3 = new BufferedReader(new InputStreamReader(System.in));
            String $r7 = $r3.readLine();
            byte[] r16 = $r7.getBytes();
            //SBCTF{haaaaaaaaaaaaaaaa}
            byte[] $r8 = { 73, -65, 27, -19, -77, 28, 108, 82, 43, 60, -14, 58, 28, 44, -21, 77, 31, 114, 43, 98, 88,
                    17, 23, -9 };

            boolean $z0 = Arrays.equals(method3(r16, $r0), $r8);

            if ($z0) {
                System.out.println("right flag!");
            } else {
                System.out.println("wrong flag!");
            }

        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}
