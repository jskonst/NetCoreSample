import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(private http: HttpClient) { }

  getBooks() {
    return this.http.get('http://localhost:5000/api/books');
  //   return [
  //   {
  //     title: 'Book1',
  //     author: 'Author1',
  //   },
  //   {
  //     title: 'Book2',
  //     author: 'Author2',
  //   },
  //   {
  //     title: 'Book3',
  //     author: 'Author3',
  //   },
  // ];
  }
}
