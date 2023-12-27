// Source code is decompiled from a .class file using FernFlower decompiler.

public class m {
   public static String ALLATORIxDEMO(String var0) {
      String var6;
      String var10000 = var6 = var0;
      StackTraceElement var11 = (new RuntimeException()).getStackTrace()[1];
      String var10004 = var11.getClassName() + var11.getMethodName();
      int var4;
      int var9 = var4 = var10004.length() - 1;
      String var5 = var10004;
      int a = var9;
      int var10001 = var10000.length();
      char[] var10 = new char[var10001];
      char[] var2 = var10;
      var9 = 3 ^ 5;
      var9 <<= 3;
      int var1 = var9 ^ 4;
      int var3 = var10001 - 1;
      char[] var8 = var2;

      for(var10001 = var3; var10001 >= 0; var10001 = var3) {
         char var15 = var5.charAt(a);
         char var10007 = var6.charAt(var3);
         --a;
         var8[var3] = (char)(var15 ^ var10007 ^ var1);
         var1 = (char)(63 & (var1 ^ var10001 ^ var15));
         if (a < 0) {
            a = var4;
         }

         --var3;
         var8 = var2;
      }

      return new String(var2);
   }
   public static String d(String a) {
   
      int var10000 = 3 ^ 5;
  
      var10000 <<= 3;
    
      var10000 ^= 3;
    
    
    
      int var10001 = 3 ^ 5;
    
      int var5 = 4 << 4;
   

      var5 ^= 3 << 1;
      int var7 = (a = (String)a).length();
      char[] var9 = new char[var7];
    
   
      int var12 = var7 - 1;
      var7 = var5;
      int var3;
      var5 = var3 = var12;
      char[] var1 = var9;
      int f_input = var7;
      var10000 = var5;

      for(int input = var10001; var10000 >= 0; var10000 = var3) {
         var10001 = var3;
         char var6 = (char)(a.charAt(var3) ^ input);
         --var3;
         var1[var10001] = var6;
         if (var3 < 0) {
            break;
         }

         var10001 = var3;
         var6 = a.charAt(var3);
         --var3;
         var1[var10001] = (char)(var6 ^ f_input);
      }

      return new String(var1);
   }
  public static String A(String var0) {
      StackTraceElement[] var10002 = (new RuntimeException()).getStackTrace();
      String var10000 = var10002[1].getClassName() + var10002[1].getMethodName();
      int var10001 = var10000.length();
   
    
      --var10001;
  
 
      int var11 = 3 ^ 5;
     
      var11 <<= 4;
    
      var11 ^= 2 << 1;
   
      int var12 = 3 ^ 5;
   
      int var15 = 3 ^ 5;
      var15 <<= 3;
    
   
      var15 ^= 2 ^ 5;
      String input;
      int var16 = (input = (String)var0).length();
      char[] var18 = new char[var16];
   
     
      int input1 = var16 - 1;
      var16 = var15;
      int var1;
      var15 = var1 = input1;
      char[] var3 = var18;
      int var7 = var16;
      int f_input = var12;
   
      int a;
      int var5 = a = var10001;
      int var9 = var15;

      for(String var6 = var10000; var9 >= 0; var9 = var1) {
         var11 = var1--;
         var3[var11] = (char)(f_input ^ input.charAt(var11) ^ var6.charAt(a));
         if (var1 < 0) {
            break;
         }

         var10001 = var1;
         char var13 = input.charAt(var1);
         --var1;
         char var14 = var6.charAt(a);
         --a;
         var3[var10001] = (char)(var7 ^ var13 ^ var14);
         if (a < 0) {
            a = var5;
         }
      }

      return new String(var3);
   }
 public static String L(String var0) {
    
     
      int var10000 = 3 ^ 5;
    
      var10000 <<= 4;
  
   
      var10000 ^= 2 ^ 5;
    
      int var10001 = 3 ^ 5;
    
      var10001 <<= 4;
     
      var10001 ^= 5;
     
     
      int var6 = 5 << 4;
   
      var6 ^= 2 << 1;
      String var3;
      int var8 = (var3 = (String)var0).length();
      char[] var10 = new char[var8];
    
      int var13 = var8 - 1;
      var8 = var6;
      int a;
      var6 = a = var13;
      char[] var1 = var10;
      int f_input = var8;
      var10001 = var10000;
      var10000 = var6;

      for(int input = var10001; var10000 >= 0; var10000 = a) {
         var10001 = a;
         char var7 = var3.charAt(a);
         --a;
         var1[var10001] = (char)(var7 ^ input);
         if (a < 0) {
            break;
         }

         var6 = a--;
         var1[var6] = (char)(var3.charAt(var6) ^ f_input);
      }

      return new String(var1);
   }
   public static String j(String var0) {
      String var2 = var0;
      String var10000 = new String();
      char[] var10002 = new char[var0.length()];
      int var10003 = 3 ^ 5;
      var10003 <<= 3;
      int var6 = var10003 ^ 4;
      int var8 = var10002.length;
      int var10 = var8 - 1;
      var10003 = var6;
      int var3;
      var6 = var3 = var10;
      char[] var1 = var10002;

      for(int a = var10003; var6 >= 0; var6 = var3) {
         char var11 = (char)(var2.charAt(var3) ^ a);
         var10003 = var3;
         char var12 = (char)(var3 ^ a);
         --var3;
         a = (char)(var12 & 63);
         var1[var10003] = var11;
         if (var3 < 0) {
            break;
         }

         var11 = (char)(var2.charAt(var3) ^ a);
         var10003 = var3;
         var12 = (char)(var3 ^ a);
         --var3;
         a = (char)(var12 & 63);
         var1[var10003] = var11;
      }

      var10000=new String(var1);
      return var10000;
   }
  public static String ALLATORIxDEMO1(String a) {
      StackTraceElement[] var10002 = (new RuntimeException()).getStackTrace();
     
      StackTraceElement var10003 = var10002[1];
      StringBuffer var10000 = new StringBuffer(var10002[1].getClassName());
      String var10001 = var10003.getMethodName();
    
     
      String var8 = var10000.insert(0, var10001).toString();
      int var10 = var8.length();
     
      --var10;
      float var12 = 1.0F;
     
      int var13 = 3 ^ 5;
    
      var13 <<= 4;
    
      var13 ^= 2 << 1;
      
      int var15 = 3 << 3;
     
     
      var15 ^= 2;
   
      int var17 = 2 ^ 5;
    
      var17 <<= 4;
     
      int var18 = 2 << 2;
    
      var17 ^= var18 ^ 3;
      var18 = (a = (String)a).length();
      char[] input0 = new char[var18];
     
      int input3 = var18 - 1;
      var18 = var17;
      int var1;
      var17 = var1 = input3;
      char[] var3 = input0;
      int var7 = var18;
      int f_input = var15;
      var12 = 2.0F;
      int input;
      int var5 = input = var10;
      int var9 = var17;

      for(String var6 = var8; var9 >= 0; var9 = var1) {
         var10 = var1;
         char var14 = a.charAt(var1);
         --var1;
         var3[var10] = (char)(f_input ^ var14 ^ var6.charAt(input));
         if (var1 < 0) {
            break;
         }

         var10 = var1;
         var14 = a.charAt(var1);
         char var16 = var6.charAt(input);
         --var1;
         char var11 = (char)(var7 ^ var14 ^ var16);
         --input;
         var3[var10] = var11;
         if (input < 0) {
            input = var5;
         }
      }

      return new String(var3);
   }
public static void main(String[] var0) {
    String b = ALLATORIxDEMO1(L(d(A(ALLATORIxDEMO(j.M(H.k(D.a("\ud84f\ude58\ud84b\ude63\ud844\ude56\ud84c\ude47\ud84f\ude52\ud84f\ude51\ud84b\ude56\ud844\ude5e\ud84c\ude5b\ud84f\ude53\ud84f\ude13\ud84b\ude55\ud847\udd4a\ud84c\ude50\ud84c\udd46\u264b\ufe5e\ud848\udd42\ud844\ude4a\ud84f\udd45\ud84f\ude60\ud84f\ude52\ud848\udd76\ud844\ude5a\ud84c\ude4a\ud84f\ude41\ud84f\ude55\ud84b\ude41\ud844\ude5e\ud84c\ude51\ud84c\udd72\ud84c\udd79\ud84b\ude5e\ud847\udd4a\ud84c\ude43\ud84f\ude5d\ud84f\ude13\ud848\udd42\ud844\ude58\ud84c\ude5e\ud84c\udd41\ud84f\ude52\ud84b\ude55\ud847\udd72\ud84c\ude56\ud84c\udd46\ud84c\udd79\ud84b\ude17\ud847\udd4a\ud84c\ude5b\ud84c\udd78\ud84f\ude45\ud84b\ude4d\ud844\ude4a\ud84c\ude10\ud84f\ude4a\ud84f\ude5c\ud84b\ude71\ud844\ude42\ud84c\ude5e\ud84f\ude4b\ud84f\ude46\ud848\udd7c\ud844\ude7d\ud84f\udd05"))))))));
    System.out.println(b);
   }

}

