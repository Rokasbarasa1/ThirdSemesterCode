package via.sdj3.colotask;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import via.sdj3.colotask.Model.ColoTask;

import java.util.HashMap;

@SpringBootApplication
public class ColotaskApp {
    public static HashMap<String, ColoTask> taskMap;
    public static void main(String[] args) {
        taskMap = new HashMap<>();
        ColoTask t1 = new ColoTask("Buy coffe for weekend");
        taskMap.put(t1.id, t1);
        ColoTask t2 = new ColoTask("Get ready for opening");
        taskMap.put(t1.id, t1);
        SpringApplication.run(ColotaskApp.class, args);
        System.out.println("it should work");
    }

}
