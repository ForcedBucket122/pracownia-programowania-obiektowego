import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Okno extends JFrame implements ActionListener, MouseListener, KeyListener {

    JPanel panel = new JPanel();
    JLabel label;
    Okno(){
        this.setSize(500,500);
        this.add(panel);

         label = new JLabel();
        JButton button1 = new JButton();
        JButton button2 = new JButton();
        JButton button3 = new JButton();
        JButton button4 = new JButton();
        JButton button5 = new JButton();
        JTextField textField = new JTextField(5);
        label.setText("label");
        button1.setText("Przycisk1");
        button2.setText("Przycisk2");
        button3.setText("Przycisk3");
        button4.setText("Przycisk4");
        button5.setText("Przycisk5");

        label.setOpaque(true);
        label.setBackground(Color.CYAN);
        button1.getAction(mouseClicked(button1));

        panel.add(label);
        panel.add(button1);
        panel.add(button2);
        panel.add(button3);
        panel.add(button4);
        panel.add(button5);
        panel.add(textField);

    }

    @Override
    public void actionPerformed(ActionEvent e) {

    }

    @Override
    public void keyTyped(KeyEvent e) {

    }

    @Override
    public void keyPressed(KeyEvent e) {

    }

    @Override
    public void keyReleased(KeyEvent e) {

    }

    @Override
    public void mouseClicked(MouseEvent e) {
        label.setText(String.valueOf(e.getButton()));
    }

    @Override
    public void mousePressed(MouseEvent e) {

    }

    @Override
    public void mouseReleased(MouseEvent e) {

    }

    @Override
    public void mouseEntered(MouseEvent e) {

    }

    @Override
    public void mouseExited(MouseEvent e) {

    }
}
