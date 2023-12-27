// Source code is decompiled from a .class file using FernFlower decompiler.
public class H {
   public static String ALLATORIxDEMO(String var0) {
      String var2 = var0;
      String var10000 = new String();
      char[] var10002 = new char[var0.length()];
      int var9 = (3 ^ 5) << 3;
      int var3;
      int var7 = var3 = var10002.length - 1;
      char[] var1 = var10002;

      for(int a = var9; var7 >= 0; var7 = var3) {
         char var4 = (char)(var2.charAt(var3) ^ a);
         int var8 = var3;
         a = (char)((char)(var3 ^ a) & 63);
         --var3;
         var1[var8] = var4;
         if (var3 < 0) {
            break;
         }

         var4 = (char)(var2.charAt(var3) ^ a);
         var8 = var3;
         a = (char)((char)(var3 ^ a) & 63);
         --var3;
         var1[var8] = var4;
      }

      var10000=new String(var1);
      return var10000;
   }

   public static String k(String var0) {
      String var3 = var0;
      StackTraceElement var10003 = (new RuntimeException()).getStackTrace()[1];
      String var10004 = var10003.getClassName() + var10003.getMethodName();
      int var4;
      int var9 = var4 = var10004.length() - 1;
      String var5 = var10004;
      int a = var9;
      int var8 = var0.length();
      char[] var10 = new char[var8];
      char[] var2 = var10;
      int var1 = (3 ^ 5) << 3;
      int var6 = var8 - 1;

      for(char[] var10000 = var2; var6 >= 0; var10000 = var2) {
         char var10005 = var5.charAt(a);
         var10000[var6] = (char)(var10005 ^ var3.charAt(var6) ^ var1);
         var8 = var1 ^ var6 ^ var10005;
         --a;
         var1 = (char)(63 & var8);
         if (a < 0) {
            a = var4;
         }

         --var6;
      }

      return new String(var2);
   }
}

