package day_04;

import challengeInterface.Challenge;

public class IsJohnnyMakingProgress implements Challenge{
    
    int progressDays(int[] milesruned){
        int progressDaysCount = 0;

        for (int i = 0; i < milesruned.length; i++) {
            if (i == 0) {
                continue;
            } else if (milesruned[i - 1] < milesruned[i]) {
                progressDaysCount += 1;
            }
        }
        return progressDaysCount;
    }

    @Override
    public void run() {
        int[] progress = {9, 9};
        System.out.println(this.progressDays(progress));
    }
}
