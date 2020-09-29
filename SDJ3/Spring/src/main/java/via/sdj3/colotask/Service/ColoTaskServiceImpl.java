package via.sdj3.colotask.Service;

import via.sdj3.colotask.ColotaskApp;
import via.sdj3.colotask.Model.ColoTask;

import java.util.HashMap;

public class ColoTaskServiceImpl implements ColoTaskService{
    @Override
    public HashMap<String, ColoTask> getAllTasks() {

        return ColotaskApp.taskMap;
    }
}
