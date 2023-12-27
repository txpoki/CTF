import java.io.ByteArrayOutputStream;
 import java.util.Arrays;
 import java.util.List;
 import java.util.Scanner;

 public class Main {

 private static final List<String> ALPHABET = Arrays.asList(
 "😀", "😁", "😂", "🤣", "😃", "😄", "😅", "😆", "😉",
 "😋", "😎", "😍", "😘", "😗", "😙", "😚", "🙂", "🤗",
 "🤩", "🤔", "🤨", "😐", "😑", "😶", "🙄", "😏", "😣",
 "😥", "🤐", "😪", "😫", "😴", "😌", "😛", "😜", "😝",
 "🤤", "😒", "😓", "😔", "😕", "🙃", "🤑", "😲", "☹️",
 "😖", "😞", "😟", "😤", "😢", "😭", "😦", "😧", "😨",
 "😩", "😬", "😰", "😱", "😳", "🤪", "😵", "🤭", "🤫");

 public static byte[] decode(String encoded) {
 int bit = 0;
 int bits = 0;
 int outputIndex = 0;
 int cpCount = encoded.codePointCount(0, encoded.length());
 byte[] output = new byte[(cpCount * 6) / 8];

 for (int i = 0; i < encoded.length(); ) {
 int codepoint = encoded.codePointAt(i);
 String emoji = new String(Character.toChars(codepoint));
 System.out.println(emoji);
 int val = ALPHABET.indexOf(emoji);
 if (val == -1) {
 int codepoint2 = encoded.codePointAt(i + 1);
 if (codepoint2 >= 0xFE00 && codepoint2 <= 0xFE0F) {
 emoji = new String(new int[]{codepoint, codepoint2}, 0, 2);
 System.out.println(emoji);
 val = ALPHABET.indexOf(emoji);
 i += Character.charCount(codepoint) + 1;
 }
 if (val == -1) {
 throw new IllegalArgumentException("Invalid emojiaracter.");
 }
 }
 else{
 i += Character.charCount(codepoint);
 }
 val = (val >> 2) | ((val & 0x3) << 4);

 bit |= val << (16 - bits - 6);
 bits += 6;

 if (bits >= 8) {
 output[outputIndex++] = (byte) ((bit >> 8) & 0xFF);
 bit <<= 8;
 bits -= 8;
 }
 }

 int paddingLength = output[0];

 return Arrays.copyOfRange(output, 1, output.length - paddingLength);
 }

public static void main(String[] args) {
byte[] decoded =decode("\uD83D\uDE09\uD83D\uDE36\uD83D\uDE0C\uD83D\uDE15\uD83D\uDE03\uD83D\uDE00\uD83D\uDE03\uD83D\uDE04\uD83D\uDE09\uD83D\uDE02\uD83D\uDE42\uD83D\uDE00\uD83E\uDD10\uD83D\uDE02\uD83E\uDD17☹️\uD83E\uDD17\uD83D\uDE10\uD83E\uDD17\uD83D\uDE31\uD83D\uDE03\uD83E\uDD23\uD83D\uDE00\uD83D\uDE18\uD83D\uDE10\uD83D\uDE04\uD83D\uDE14\uD83D\uDE04\uD83D\uDE03\uD83E\uDD23\uD83E\uDD28\uD83D\uDE0B\uD83E\uDD10\uD83D\uDE11\uD83D\uDE0C\uD83D\uDE42\uD83E\uDD17\uD83D\uDE02\uD83D\uDE0C\uD83E\uDD10\uD83D\uDE03\uD83D\uDE00\uD83E\uDD28\uD83D\uDE04\uD83E\uDD17\uD83E\uDD28\uD83D\uDE42\uD83E\uDD10\uD83D\uDE09\uD83E\uDD29\uD83D\uDE14\uD83D\uDE18\uD83D\uDE10\uD83D\uDE42\uD83D\uDE1B\uD83D\uDE0D\uD83D\uDE24\uD83D\uDE18\uD83D\uDE0C\uD83D\uDE1A\uD83D\uDE17\uD83E\uDD29\uD83D\uDE27\uD83E\uDD17");
for (int i = 0; i < decoded.length; i++) {
    decoded[i] = (byte) (decoded[i] ^ 0x33);
}
    System.out.println("括号内的flag是:" + new String(decoded));
}
}
//a973b923-68bf-430f-b42a-a7a1472bcb49