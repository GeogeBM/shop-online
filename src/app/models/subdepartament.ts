export class SubDepartament{

    subDepartamentId: number;
    subDepartamentDesc: string;
    DepartamentId: number;
    createdate: Date;
    modifydate: Date;

    constructor(){
        this.subDepartamentId=0;
        this.subDepartamentDesc='';
        this.DepartamentId = 0;
        this.createdate = new Date()
        this.modifydate = new Date();
    }
}