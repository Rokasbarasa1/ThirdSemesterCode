package via.sdj3.colotask.Controller;

import lombok.AccessLevel;
import lombok.AllArgsConstructor;
import lombok.experimental.FieldDefaults;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;
import via.sdj3.colotask.Model.ColoTask;
import via.sdj3.colotask.Service.ColoTaskService;

import javax.validation.constraints.NotNull;
import java.util.HashMap;

@RestController
@RequestMapping("/colotask")
@AllArgsConstructor(access = AccessLevel.PACKAGE)
@FieldDefaults(level = AccessLevel.PRIVATE, makeFinal = true)
public class ColoTaskController {
    //@Autowired
    //private ColoTaskService coloTask;
    @NotNull
    public ColoTaskService coloTask;
    @RequestMapping(value ="/", method = RequestMethod.GET)
    public HashMap<String, ColoTask> getAllTasks(){
        return coloTask.getAllTasks();
    }
}
