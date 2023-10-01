public class Solution {
    public bool SquareIsWhite(string coordinates) {
        byte colByte  = (byte)(coordinates[0] - 96);
        byte rowByte = (byte)(coordinates[1] - 48);
        
        int sum = colByte + rowByte;
        return sum % 2 != 0;
        }
}