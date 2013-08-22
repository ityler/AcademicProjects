/*
 * Tyler Normile
 * 03-06-2013
 * Java program to calculate area and perimeter
 */
package squarecalc1;

import javax.swing.JOptionPane;
import java.text.DecimalFormat;

public class SquareCalc1 {
    public static void main(String[] args) {
        String response;
        response = JOptionPane.showInputDialog (null, "Enter the length of one side of a square:"); 
        double side = Double.parseDouble(response);
        //double area = calculateAREA(side * side);
        //double area = Double.parseDouble(response);
        
        //Calculate area
        double area = calculateAREA(side);
        //Calculate Perimeter
        double perimeter = calculatePERIMETER(side);
        
        //Show area and perimeter in result MessageDialog
        JOptionPane.showMessageDialog(null, "The area is " + area + "\n" + "The perimeter is " + perimeter);
    }
    
        //Area method
         public static double calculateAREA(double side){
            return (side * side);
        }
         //Perimeter method
         public static double calculatePERIMETER(double side){
             return (side * 4);
         }
      }
