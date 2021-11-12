package pt.ipleiria.estg.dei.ei.dae.academics.dtos;

import java.io.Serializable;

public class DocumentDTO  implements Serializable {
    private long id;
    private String filepath;
    private String fileName;

    public DocumentDTO() {
    }
    public DocumentDTO(long id, String filepath, String fileName) {
        this.filepath = filepath;
        this.fileName = fileName;
        this.id = id;
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getFilepath() {
        return filepath;
    }

    public void setFilepath(String filepath) {
        this.filepath = filepath;
    }

    public String getFileName() {
        return fileName;
    }

    public void setFileName(String fileName) {
        this.fileName = fileName;
    }
}
