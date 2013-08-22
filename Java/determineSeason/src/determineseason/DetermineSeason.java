/*
 * Tyler Normile
 * 3/12/2013
 * JDK Version 7.2.1
 * This program will determine the season based on temperature entered
 */
package determineseason;

import javax.swing.*;

public class determineSeason {
    public static void main(String[] args) {
        int inputTemp;
        String response = JOptionPane.showInputDialog(null, "Enter the temperature" , "Probably season" ,1);
        inputTemp = Integer.parseInt(response);
        String message = "Based on the temperature of "
                + inputTemp + " it is most likely " + determineSeason(inputTemp);
        JOptionPane.showMessageDialog(null, message);
        
    public static String determineSeason(int inputTemp){
        if (inputTemp > 130 | inputTemp < -20) {
                return "invalid";
            }   
            else if (inputTemp >= 90) {
                return "summer";
            }
            else if (inputTemp >= 70) {
                return "spring";
            }
            else if (inputTemp >= 50) {
                return "fall";
            }
            else if (inputTemp < 50) {
                return "winter";
            }
            else
                return "invalid";    
        
    }//ends main
}//ends the program
