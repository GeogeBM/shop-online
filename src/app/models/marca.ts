export class Marca{
    marcaId: number;
    marcaDesc: string;
    createDate: Date;
    modifyDate: Date;
    constructor(){
        this.marcaId = 0;
        this.marcaDesc ='';
        this.createDate = new Date();
        this.modifyDate = new Date();

    }
}