export class Marca{
    marca_id: number;
    marca_desc: string;
    create_date: Date;
    modify_date: Date;
    constructor(){
        this.marca_id = 0;
        this.marca_desc ='';
        this.create_date = new Date();
        this.modify_date = new Date();

    }
}