public class Solution {
    public void MoveZeroes(int[] nums) {
        //loop through the array, if nums[i] == 0, splice
        if (nums == null || nums.Length <= 1) return;

        int write = 0;
        for (int read = 0; read < nums.Length; read++){
            if (nums[read] != 0){
                if(read != write){
                    //Swap nums[read] with nums[write]
                    int temp = nums[write];
                    nums[write] = nums[read];
                    nums[read] = temp;
                }
                write++;
            }
        }
        
    

    }
}