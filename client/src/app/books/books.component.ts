import { Component, OnInit } from '@angular/core';
import { BooksService } from '../books.service';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})

// class Book {
//   title: string;
//   author: string;
// }


export class BooksComponent implements OnInit {

  books = [];

  constructor(private booksService: BooksService) { }

  ngOnInit() {
    this.booksService.getBooks().subscribe((data: any) => {
      this.books = data;
    });
  }

}
