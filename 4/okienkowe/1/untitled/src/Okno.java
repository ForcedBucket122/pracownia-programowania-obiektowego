import javax.swing.*;
import java.awt.*;

public class Okno extends JFrame {
    private JPanel jPanel;
    private JButton jButton;
    private JLabel jLabel;
    public Okno(){
        this.setTitle("JD");
        this.setSize(600,300);

        jPanel = new JPanel();
        jPanel.setBackground(Color.CYAN);

        jButton = new JButton();
        jButton.setText("NIGGA");
        jButton.setBackground(new Color(123, 15, 67));
        jButton.setForeground(Color.white);

        jLabel = new JLabel();
        jLabel.setText("Nigga2");

        this.add(jPanel);
       jPanel.add(jButton);
       jPanel.add(jLabel);


    }

}
