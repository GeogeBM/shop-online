export class Departament{
    departament_Id: number;
    departament_descripcion: string;
    create_date: Date; 
    modify_date: Date;

    constructor(){
        this.departament_Id=0
        this.departament_descripcion='';
        this.create_date = new Date();
        this.modify_date = new Date();
    }

}