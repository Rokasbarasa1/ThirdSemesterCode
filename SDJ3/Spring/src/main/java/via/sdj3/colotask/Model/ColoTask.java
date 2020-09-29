package via.sdj3.colotask.Model;

import lombok.Data;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.NotNull;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.util.UUID;

@Data
public class ColoTask {
    @NotNull
    public String id;
    @NotNull
    @NotBlank
    private String description;
    private LocalDateTime dateCreated;
    private LocalDateTime dateModified;
    private boolean isCompleted;

    public ColoTask(){
        LocalDateTime date = LocalDateTime.now();
        this.id = UUID.randomUUID().toString();
        this.dateCreated = date;
    }

    public ColoTask(String description){
        this();
        this.description = description;
    }
}
