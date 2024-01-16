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
                int n = (r1[i + 1] + k) ^ m;
                int o = (r1[i + 1] >> 5) + r3[1];
                int p = n ^ o;
                r1[i] += p;
                int q = (r1[i] << 4) + r3[2];
                int r = (r1[i] + k) ^ q;
                int s = (r1[i] >> 5) + r3[3];
                int t = r ^ s;
                r1[i + 1] += t;
                j++;
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
            System.out.println("please input the known part of your flag (e.g., SBCTF{66}):");
            BufferedReader $r3 = new BufferedReader(new InputStreamReader(System.in));
            String knownPart = $r3.readLine();
            byte[] r16 = knownPart.getBytes();

            byte[] remainingPart = new byte[2];

            for (int i = 0; i < 256; i++) {
                for (int j = 0; j < 256; j++) {
                    remainingPart[0] = (byte) i;
                    remainingPart[1] = (byte) j;

                    byte[] $r8 = { 73, -65, 27, -19, -77, 28, 108, 82 };

                    boolean $z0 = Arrays.equals(method3(concatArrays(r16, remainingPart), $r0), $r8);

                    if ($z0) {
                        System.out.println("Found flag: " + knownPart + new String(remainingPart));
                        return;
                    }
                }
            }

            System.out.println("Flag not found.");

        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

    private static byte[] concatArrays(byte[] arr1, byte[] arr2) {
        byte[] result = new byte[arr1.length + arr2.length];
        System.arraycopy(arr1, 0, result, 0, arr1.length);
        System.arraycopy(arr2, 0, result, arr1.length, arr2.length);
        return result;
    }
}
