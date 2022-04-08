export class Departament{
    departamentId: number;
    departamentDescripcion: string;
    createDate: Date; 
    modifyDate: Date;

    constructor(){
        this.departamentId=0
        this.departamentDescripcion='';
        this.createDate = new Date();
        this.modifyDate = new Date();
    }

}
