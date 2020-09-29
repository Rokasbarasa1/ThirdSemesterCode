package via.sdj3.colotask.Service;

import via.sdj3.colotask.Model.ColoTask;

import java.util.HashMap;

public interface ColoTaskService {
    //Http get --> READ
    HashMap<String, ColoTask> getAllTasks();

}
