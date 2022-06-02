import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { environment } from '../../../environments/environment';

@Injectable({
    providedIn: 'root'
  })

export class GenericService
{

    constructor(private httpClient: HttpClient){

    }


    public getRequest(url:string, params:any){
        return this.Execute(HttpRequestType.GET,url,params);
    }
    
    public postReques(url:string, params:any){
        return this.Execute(HttpRequestType.POST,url,null,params);
    }
    public postFilesReques(url:string,params:any){
        const headers = new HttpHeaders();
        return this.Execute(HttpRequestType.POSTFILE,url,headers,params)
    }
    public putRequest(url:string, params:any){
        return this.Execute(HttpRequestType.PUT,url,params);
    }
    
    public deleteRequest(url:string,params:any){
        return this.Execute(HttpRequestType.DELETE,url,params);
    }


    
    private Execute(requestType: HttpRequestType, url:string, params:any, data:any = null){


        //let URL  = 'https://localhost:44356/api/'; //`${environment.service_url}`;
        let URL = environment.api_url;
        URL += url;
        console.log('la Url a pedir el usuario es: ', URL);
        //creando parametros
        let queryParams = new HttpParams({fromObject:params});
        
        console.log('los parametros enviados antes de ejecutar ',queryParams);
        //iniciando headers
        let headers = new HttpHeaders();
        headers = headers.set('Content-type', 'application/json');
        switch(requestType){

            case HttpRequestType.GET:
                return this.httpClient.get(URL,{headers:headers, params: queryParams});
            
            case HttpRequestType.POST:
                return this.httpClient.post(URL,data,{headers:headers, params: queryParams} );
            case HttpRequestType.POSTFILE:
                return this.httpClient.post(URL,data, {headers: new HttpHeaders()})
            case HttpRequestType.PUT:
                return this.httpClient.put(url,{headers:headers, params:queryParams});
            
                case HttpRequestType.DELETE:
                return this.httpClient.delete(URL,{headers:headers, params:queryParams});
        }

    }
}

enum HttpRequestType{
    GET,
    POST,
    PUT,
    DELETE,
    POSTFILE
    }