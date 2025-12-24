import { Component, inject, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ProductService } from './product.service';
import { Product } from './product.model';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'products';
  products = signal<Product[]>([]);
  productService = inject(ProductService);
  ngOnInit() {
    this.productService.getProducts().subscribe(products => {
      console.log(products);
      this.products.set(products as Product[]);
    }); 
  }
}
