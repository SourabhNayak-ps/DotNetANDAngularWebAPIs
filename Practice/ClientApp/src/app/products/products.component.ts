import { Component, OnInit } from '@angular/core';
import { Product } from '../models/Product';
// import { ProductsService } from 'src/app/services/ProductService';
import { ProductService } from '../services/ProductService';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent {
  products:Product[]=[];

  constructor(private productService : ProductService) {
   
    this.productService.fetchProductList().subscribe(
      (prod) => {
        this.products = prod;
        console.log(this.products);
      },
      (error) => {
        console.log(error);
      }
    )
  }

  // ngOnInit(): void {
  //   this.productService.fetchProductList().subscribe(
  //     (prod) => {
  //       this.products = prod;
  //       console.log(this.products);
  //     },
  //     (error) => {
  //       console.log(error);
  //     }
  //   );
  // }

}
