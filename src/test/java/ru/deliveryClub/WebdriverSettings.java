package ru.deliveryClub;
import org.openqa.selenium.support.PageFactory;
import org.openqa.selenium.WebDriver;

class WebdriverSettings {
    static Integer a,b,c;
    public static void main(String[] args) {
        c = a < b ? a-- + c++ : b++ ;
        System.out.println(String.format("c = %d a = %d b =%d",c,a,b));
    }
}


public class LoginPage {

    public LoginPage(WebDriver driver) {
        PageFactory.initElements(driver, this);
        this.driver = driver;
    }

    public WebDriver driver;
}