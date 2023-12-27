// Source code is decompiled from a .class file using FernFlower decompiler.
public class j {
   public static String ALLATORIxDEMO(String var0) {
      String var6 = var0;
      StackTraceElement var10003 = (new RuntimeException()).getStackTrace()[1];
      String var10004 = var10003.getClassName() + var10003.getMethodName();
      int var4;
      int var9 = var4 = var10004.length() - 1;
      String var5 = var10004;
      int var3 = var9;
      int var10001 = var0.length();
      char[] var10 = new char[var10001];
      char[] var2 = var10;
      int var1 = 2 ^ 5;
      int a = var10001 - 1;
      char[] var10000 = var2;

      for(var10001 = a; var10001 >= 0; var10001 = a) {
         char var10005 = var5.charAt(var3);
         char var8 = (char)(var10005 ^ var6.charAt(a) ^ var1);
         --var3;
         var10000[a] = var8;
         var1 = (char)(63 & (var1 ^ var10001 ^ var10005));
         if (var3 < 0) {
            var3 = var4;
         }

         --a;
         var10000 = var2;
      }

      return new String(var2);
   }

   public static String M(String var0) {
      String var2 = var0;
      char[] var10002 = new char[var0.length()];
      int var10 = 2 ^ 5;
      int a;
      int var8 = a = var10002.length - 1;
      char[] var1 = var10002;

      for(int var3 = var10; var8 >= 0; var8 = a) {
         char var4 = (char)(var2.charAt(a) ^ var3);
         int var9 = a;
         char var5 = (char)(a ^ var3);
         --a;
         char var7 = (char)(var5 & 63);
         var1[var9] = var4;
         if (a < 0) {
            break;
         }

         var4 = (char)(var2.charAt(a) ^ var7);
         var9 = a;
         var5 = (char)(a ^ var7);
         --a;
         var3 = (char)(var5 & 63);
         var1[var9] = var4;
      }

      return new String(var1);
   }
}

