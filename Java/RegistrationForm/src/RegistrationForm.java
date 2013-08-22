/*
Place comments here....
 */

import java.awt.*;	//import older gui library for content pane
import javax.swing.*;	//import newer gui library for labels, textfields, and button
import java.awt.event.*; //import gui event action library

public class RegistrationForm extends JFrame implements ActionListener {

    // declare labels used on GUI screen
    private JLabel labelName, labelAddress, labelCity, labelState, labelZip, labelPhone, labelEmail, labelPassword, labelPassword2;
    private JLabel labelError, labelRegistration;  // used for good and bad messages
    // declare text fields used on GUI screen
    private JTextField textName, textAddress, textCity, textState, textZip, textPhone, textEmail, textPassword, textPassword2;
    // declare button used on GUI screen
    private JButton submitButton, clearButton;
    // declare content pane
    private Container contentPane;

    public RegistrationForm() {
        createGUI();
    } // ends  constructor

    private void createGUI() {
        try {
            // get content pane and set the layout to null
            contentPane = getContentPane();
            contentPane.setLayout(null);	//free-form layout
            setFont(new Font("TimesRoman", Font.ITALIC, 14));

            // create the name label
            labelName = new JLabel();	//instantiate new JLabel
            labelName.setText("Name");	//set label text to name
            labelName.setLocation(38, 10);	//set location of JLabel
            labelName.setSize(200, 25);	//set size of JLabel
            labelName.setForeground(Color.BLACK);//set initial background color
            contentPane.add(labelName);	//add JLabel to content pane

            // create the name text box
            textName = new JTextField();	//instantiate new JTextField
            textName.setText("");	//clear JTextField
            textName.setToolTipText("Please type in full name - last name first");
            textName.setLocation(75, 10);	//set location of JTextFfield
            textName.setSize(200, 25);   //set size of JTextField
            contentPane.add(textName); //add jextfield to content pane

            // create the address label
            labelAddress = new JLabel();
            labelAddress.setText("Address");
            labelAddress.setLocation(23, 50);
            labelAddress.setSize(80, 25);
            labelAddress.setForeground(Color.BLACK);
            contentPane.add(labelAddress);

            // create the address text box
            textAddress = new JTextField();
            textAddress.setText("");
            textAddress.setToolTipText("Please type in full address");
            textAddress.setLocation(75, 50);
            textAddress.setSize(300, 25);
            contentPane.add(textAddress);

            // create the city label
            labelCity = new JLabel();
            labelCity.setText("City");
            labelCity.setLocation(48, 90);
            labelCity.setSize(300, 25);
            labelCity.setForeground(Color.BLACK);
            contentPane.add(labelCity);

            // create the city text box
            textCity = new JTextField();
            textCity.setText("");
            textCity.setToolTipText("Please type in full city");
            textCity.setLocation(75, 90);
            textCity.setSize(130, 25);
            contentPane.add(textCity);

            // create the state label
            labelState = new JLabel();
            labelState.setText("State");
            labelState.setLocation(40, 130);
            labelState.setSize(300, 25);
            labelState.setForeground(Color.BLACK);
            contentPane.add(labelState);

            // create the state text box
            textState = new JTextField();
            textState.setText("");
            textState.setToolTipText("Choose State");
            textState.setLocation(75, 130);
            textState.setSize(130, 25);
            contentPane.add(textState);

            // create the zip label
            labelZip = new JLabel();
            labelZip.setText("Zip Code");
            labelZip.setLocation(18, 170);
            labelZip.setSize(300, 25);
            labelZip.setForeground(Color.BLACK);
            contentPane.add(labelZip);

            // create the zip text box
            textZip = new JTextField();
            textZip.setText("");
            textZip.setToolTipText("Zip code must be between 10000 and 99999 inclusive");
            textZip.setLocation(75, 170);
            textZip.setSize(130, 25);
            contentPane.add(textZip);
            
            // create the phone label
            labelPhone = new JLabel();
            labelPhone.setText("Phone");
            labelPhone.setLocation(35, 210);
            labelPhone.setSize(300, 25);
            labelPhone.setForeground(Color.BLACK);
            contentPane.add(labelPhone);
            
            // create the phone text box
            textPhone = new JTextField();
            textPhone.setText("");
            textPhone.setToolTipText("Phone must start with 412 or 724");
            textPhone.setLocation(75, 210);
            textPhone.setSize(130, 25);
            contentPane.add(textPhone);
            
            // create the email label
            labelEmail = new JLabel();
            labelEmail.setText("Email");
            labelEmail.setLocation(38, 250);
            labelEmail.setSize(300, 25);
            labelEmail.setForeground(Color.BLACK);
            contentPane.add(labelEmail);
            
            // create the email text box
            textEmail = new JTextField();
            textEmail.setText("");
            textEmail.setToolTipText("Must be a valid email address containing ' @ '");
            textEmail.setLocation(75, 250);
            textEmail.setSize(130, 25);
            contentPane.add(textEmail);
            
            // create the password label 
            labelPassword = new JLabel();
            labelPassword.setText("Password");
            labelPassword.setLocation(15, 290);
            labelPassword.setSize(300, 25);
            labelPassword.setForeground(Color.BLACK);
            contentPane.add(labelPassword);
            
            // create the password text box
            textPassword = new JTextField();
            textPassword.setText("");
            textPassword.setToolTipText("Must be a valid password that matches");
            textPassword.setLocation(75, 290);
            textPassword.setSize(130, 25);
            contentPane.add(textPassword);
            
            // creat the password2 label
            labelPassword2 = new JLabel();
            labelPassword2.setText("Re-Password");
            labelPassword2.setLocation(5, 330);
            labelPassword2.setSize(300, 25);
            labelPassword2.setForeground(Color.BLACK);
            contentPane.add(labelPassword2);

            // create the password2 text box
            textPassword2 = new JTextField();
            textPassword2.setText("");
            textPassword2.setToolTipText("Passwords must match");
            textPassword2.setLocation(88, 330);
            textPassword2.setSize(130, 25);
            contentPane.add(textPassword2);
            
            // create the submit button
            submitButton = new JButton();
            submitButton.setText("Submit");
            submitButton.setToolTipText("Click \"submit \" when the form is completely filled out");
            submitButton.setLocation(125, 450);
            submitButton.setSize(100, 30);
            contentPane.add(submitButton);
            submitButton.addActionListener(this);

            clearButton = new JButton();
            clearButton.setText("Clear");
            clearButton.setToolTipText("Click \"clear \" when you want to clear the form");
            clearButton.setLocation(250, 450);
            clearButton.setSize(100, 30);
            contentPane.add(clearButton);
            clearButton.addActionListener(this);

            // create the error label
            labelError = new JLabel();
            labelError.setText("Please correct items in red");
            labelError.setLocation(150, 500);
            labelError.setSize(190, 25);
            labelError.setForeground(Color.RED);
            labelError.setVisible(false);
            contentPane.add(labelError);

            // create the registration label
            labelRegistration = new JLabel();
            labelRegistration.setText("Thank you for your registration.");
            labelRegistration.setLocation(145, 500);
            labelRegistration.setSize(190, 25);
            labelRegistration.setForeground(Color.BLACK);
            labelRegistration.setVisible(false);
            contentPane.add(labelRegistration);

            // set properties of window
            setTitle("Registration Form");	//set window title
            setSize(475, 600); //set window size
            setVisible(true);
        } catch (Exception e) {
        }
    }// ends creatGUI method.

    public static void main(String args[]) {
        RegistrationForm application = new RegistrationForm();
        application.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }// ends main

    public void actionPerformed(ActionEvent event) {
        try {
            if (event.getActionCommand().equals("Submit")) {
                //Statements get executed here when SUBMIT button is pressed.
                //Using the "&" instead of "&&" ensures that all check methods get called.
                //If you used the "&", you would only see one error at a time.
                //The form cannot be submitted until all the errors are fixed (every method returns true).
                if (checkName() & checkAddress() & checkCity() & checkState() & checkZip() & checkPhone() & checkEmail() & checkPassword()) {
                    labelRegistration.setVisible(true); //all information is entered and correct
                    labelError.setVisible(false);	    //hide this message if visible
                    submitButton.removeActionListener(this); // stop listening to submit button - form complete
                    clearButton.removeActionListener(this);  // stop listening to clear button - form complete
                } else {
                    labelError.setVisible(true);   //all information is not valid on form
                    labelRegistration.setVisible(false); //hide this message when bad information entered
                }
            } if (event.getActionCommand().equals("Clear")) 
                {
                textName.setText("");
                textAddress.setText("");
                textCity.setText("");
                textState.setText("");
                textZip.setText("");
                textPhone.setText("");
                textEmail.setText("");
                textPassword.setText("");
                textPassword2.setText("");
                labelError.setVisible(false);
                labelRegistration.setVisible(false);
                labelName.setForeground(Color.BLACK);
                labelAddress.setForeground(Color.BLACK);
                labelCity.setForeground(Color.BLACK);
                labelState.setForeground(Color.BLACK);
                labelZip.setForeground(Color.BLACK);
                labelPhone.setForeground(Color.BLACK);
                labelEmail.setForeground(Color.BLACK);
                labelPassword.setForeground(Color.BLACK);
                labelPassword2.setForeground(Color.BLACK);
            }
        } catch (Exception e) { }
    }// ends actionPerformed method

    /* The checkName method looks at the contents of the name text field.
    The method requires that the length is greater than zero to pass (return true).
    If the length is greater than zero, the method returns true and sets the label
    color to black. If the length is zero, the method returns false and changes the
    label color to red.   */
    private boolean checkName() {
        if (textName.getText().length() == 0) {
            labelName.setForeground(Color.RED);	//name is not correct
            return false;
        } else {
            labelName.setForeground(Color.BLACK); //name is correct
            return true;
        }
    } //end of method


    /* The checkAddress method looks at the contents of the address text field.
    The method requires that the length is at least 5 to pass (return true).
    If the length is at least 5, the method returns true and sets the label
    color to black. If the length is less than 5, the method returns false and
    changes the label color to red.    */
    private boolean checkAddress() {
        if (textAddress.getText().length() < 5) {
            labelAddress.setForeground(Color.RED);	//address is not correct
            return false;
        } else {
            labelAddress.setForeground(Color.BLACK);	//address is correct
            return true;
        }
    } //end of method

    /* The checkCity method looks at the contents of the city text field.
    The method requires that the length is greater than zero to pass (return true).
    If the length is greater than zero, the method returns true and sets the label
    color to black. If the length is zero, the method returns false and changes the
    label color to red.   */
    private boolean checkCity() {
        if (textCity.getText().length() == 0) {
            labelCity.setForeground(Color.RED);	//city is not correct
            return false;
        } else {
            labelCity.setForeground(Color.BLACK);	//city is correct
            return true;
        }
    } //end of method


    /* The checkState method looks at the contents of the state text field.
    The method requires that the state be in the state array.  The for loop goes through every state in the state array
    checking to see if the state that the user entered was found (sets the isFound variable at true). If it finishes the loop
    and the isFound variable was never set to true, then that user's state was not found in the state array.  If the state was
    found, the method returns true and sets the label color to black. If the state was not found, the method returns false
    and changes the label color to red.  */
    private boolean checkState() {
        String stateArray[] = {"al", "ak", "az", "ar", "ca", "co", "de", "dc", "fl", "ga", "hi", "id", "il", "in",
            "ia", "ks", "ky", "la", "me", "md", "ma", "mi", "mn", "ms", "mo", "mt", "ne", "nv", "nh", "nj", "nm",
            "nc", "nd", "oh", "ok", "or", "pa", "ri", "sc", "sd", "tn", "tx", "ut", "vt", "va", "wa", "wv", "wi", "wy"};

        boolean isFound = false;
        for (int i = 0; i < stateArray.length; i++) {
            if (textState.getText().equalsIgnoreCase(stateArray[i])) {
                isFound = true;
            }
        }
        if (isFound == true) {
            labelState.setForeground(Color.BLACK);	//state is correct
            return true;
        } else {
            labelState.setForeground(Color.RED);	//state is not correct
            return false;
        }
    } //end of method


    /* The checkZip method looks at the contents of the zip code field.
    The method requires that the zip code be an integer and be a length of 5 to pass.  If it passes it would return true
    and set the label color to black. If zip code isn't a number or is less/more than 5 characters long, the method
    would return false and set the label color to red. */
    private boolean checkZip() {
        try {
            Integer.parseInt(textZip.getText());        //zip is a number

            if (textZip.getText().length() == 5) {
                labelZip.setForeground(Color.BLACK);	//zip is correct length
                return true;
            } else {
                labelZip.setForeground(Color.RED);	//zip is not correct length
                return false;
            }
        } catch (Exception e) {
            labelZip.setForeground(Color.RED);          //zip is not a number
            return false;
        }
    } //end of method
    
    /* The checkPhone method looks at the contents of the phone field.
     The method requires that the phone be an integer that starts with 412 or 724
     * 
     */
    private boolean checkPhone() {
            
            if (textPhone.getText().startsWith("412") || textPhone.getText().startsWith("724")) 
            {
                labelPhone.setForeground(Color.BLACK);	//phone is correct length
                return true;
            } else {
                labelPhone.setForeground(Color.RED);	//phone is not correct length
                return false;
            }
            
    } //end of method
    
    /* The checkEmail method looks at the contents of the email field
     * The method requires that the email field contains an ' @ ' character
     */
    private boolean checkEmail() {
        if (textEmail.getText().contains("@"))
        {
            labelEmail.setForeground(Color.BLACK);	//email is correct and contains @ symbol
                return true;
        } else
        {
            labelEmail.setForeground(Color.RED);	//email is not correct 
                return false;
        }
    } //end of the method
    
    /* The checkPassword method looks at the contents of the password fields
     * The method requires that the password and password2 fields match
     */
    private boolean checkPassword() {
        if (textPassword.getText().equals(textPassword2.getText()))
            
        {
            labelPassword.setForeground(Color.BLACK);	//passwords match
            labelPassword2.setForeground(Color.BLACK);
                return true;
        } else
        {
            labelPassword.setForeground(Color.RED);	//passwords do not match
            labelPassword2.setForeground(Color.RED);
                return false;
        }
    } // end of the method
    
}// ends program

