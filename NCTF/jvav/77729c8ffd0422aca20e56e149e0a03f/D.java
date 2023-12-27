// Source code is decompiled from a .class file using FernFlower decompiler.
public class D {
   public static String a(String a) {
      char[] var10002 = new char[a.length()];
      int var8 = (3 ^ 5) << 4 ^ 3;//768  300
      int var3;
      int var6 = var3 = var10002.length - 1;
      char[] var1 = var10002;

      for(int var2 = var8; var6 >= 0; var6 = var3) {
         char var4 = (char)(a.charAt(var3) ^ var2);
         char var5 = (char)((char)(var3 ^ var2) & 63);
         var1[var3] = var4;
         --var3;
         if (var3 < 0) {
            break;
         }

         var4 = (char)(a.charAt(var3) ^ var5);
         var2 = (char)((char)(var3 ^ var5) & 63);
         var1[var3] = var4;
         --var3;
      }
      String restult = new String(var1);
      return restult;
   }

   public static String ALLATORIxDEMO(String a) {
      StackTraceElement var10003 = (new RuntimeException()).getStackTrace()[1];
      String var10004 = var10003.getClassName() + var10003.getMethodName();
      int var3;
      int var8 = var3 = var10004.length() - 1;
      String var2 = var10004;
      int var4 = var8;
      int var10001 = a.length();
      char[] var5 = new char[var10001];
      int var6 = (3 ^ 5) << 4 ^ 3;

      for(int var7 = var10001 - 1; var7 >= 0; --var7) {
         char var10005 = var2.charAt(var4);
         var5[var7] = (char)(var10005 ^ a.charAt(var7) ^ var6);
         var6 = (char)(63 & (var6 ^ var7 ^ var10005));
         --var4;
         if (var4 < 0) {
            var4 = var3;
         }
      }

      return new String(var5);
   }

//public static void main(String[] var0) {
//    String b = a("\ud84f\ude58\ud84b\ude63\ud844\ude56\ud84c\ude47\ud84f\ude52\ud84f\ude51\ud84b\ude56\ud844\ude5e\ud84c\ude5b\ud84f\ude53\ud84f\ude13\ud84b\ude55\ud847\udd4a\ud84c\ude50\ud84c\udd46\u264b\ufe5e\ud848\udd42\ud844\ude4a\ud84f\udd45\ud84f\ude60\ud84f\ude52\ud848\udd76\ud844\ude5a\ud84c\ude4a\ud84f\ude41\ud84f\ude55\ud84b\ude41\ud844\ude5e\ud84c\ude51\ud84c\udd72\ud84c\udd79\ud84b\ude5e\ud847\udd4a\ud84c\ude43\ud84f\ude5d\ud84f\ude13\ud848\udd42\ud844\ude58\ud84c\ude5e\ud84c\udd41\ud84f\ude52\ud84b\ude55\ud847\udd72\ud84c\ude56\ud84c\udd46\ud84c\udd79\ud84b\ude17\ud847\udd4a\ud84c\ude5b\ud84c\udd78\ud84f\ude45\ud84b\ude4d\ud844\ude4a\ud84c\ude10\ud84f\ude4a\ud84f\ude5c\ud84b\ude71\ud844\ude42\ud84c\ude5e\ud84f\ude4b\ud84f\ude46\ud848\udd7c\ud844\ude7d\ud84f\udd05");
//    System.out.println(b);
//   }


}

