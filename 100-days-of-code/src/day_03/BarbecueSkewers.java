package day_03;

import java.util.Arrays;
import java.util.List;

import challengeInterface.Challenge;

public class BarbecueSkewers implements Challenge{
    
    int[] readGrillList(List<String> grillList){
        int[] result = {0, 0};
        // [# vegetarian skewers, # non-vegetarian skewers]
        for (String grillLine : grillList) {
            String meatSignal = "-x";
            if (grillLine.contains(meatSignal)) {
                result[1] += 1;
            }else {
                result[0] += 1;
            }
        }
        return result;
    }


    @Override
    public void run() {
        List<String> testList = Arrays.asList(
            "--oooo-ooo--",
  "--xxxxxxxx--",
  "--o---",
  "-o-----o---x--",
  "--o---o-----");

        int[] result = this.readGrillList(testList);
        System.out.println(String.format("[%x, %x]", result[0], result[1]));
        
    }
}
