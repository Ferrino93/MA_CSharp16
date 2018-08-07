package ru.deliveryClub;

import org.apache.commons.io.FileUtils;
import org.junit.Assert;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.OutputType;
import sun.misc.IOUtils;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class FirstTest extends WebdriverSettings{
    @Test
    public void firstTest() {
        driver.get("https://my.lifecell.ua/ru/");
        String title = driver.getTitle();
        Assert.assertTrue(title.equals("lifecell. Подключай будущее - 3G+ сеть №1. Cамый быстрый 3G Интернет в Украине!"));
    }
    @Test
    public void secondtest() {
        driver.get("https://my.lifecell.ua/ru/");
        driver.findElement(By.cssSelector("a[href*='https://itunes.apple.com']")).click();
    }
    @Test
    public void thirdTest() throws IOException {

        driver.get("https://my.lifecell.ua/ru/");
        byte[] file = driver.getScreenshotAs(OutputType.BYTES);
        FileUtils.writeByteArrayToFile(new File("C:\\Users\\silch\\Pictures\\screen.png"), file);
//        findElement(By.tagName())
    }

}
