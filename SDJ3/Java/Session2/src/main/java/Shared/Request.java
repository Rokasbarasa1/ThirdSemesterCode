package Shared;

public class Request {
    private String type;
    private String command;
    private String  parameters;

    public Request (String type, String parameters, String command){
        this.type = type;
        this.parameters = parameters;
        this.command = command;
    }

    public String getType() {
        return type;
    }

    public String getParameters() {
        return parameters;
    }

    public String getCommand() {
        return command;
    }
}
