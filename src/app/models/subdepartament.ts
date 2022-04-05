export class SubDepartament{

    sub_departament_Id: number;
    sub_departament_desc: string;
    Departament_Id: number;
    create_date: Date;
    modify_date: Date;

    constructor(){
        this.sub_departament_Id=0;
        this.sub_departament_desc='';
        this.Departament_Id = 0;
        this.create_date = new Date()
        this.modify_date = new Date();
    }
}