import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiUrl } from '../helpers/urls';
import { Product } from '../models/Product';

@Injectable({
    providedIn: 'root',
  })
export class ProductService {
    constructor(private http: HttpClient) {}
  
    fetchProductList(): Observable<Product[]> {
      let url = ApiUrl.GetProductListUrl();
      console.log(url);
      return this.http.get<Product[]>(url);
    }

}
  
