import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, delay, map, tap } from 'rxjs';

export interface Post {
  contentId: number;
  title: string;
  body: string;
  createdAt: Date;
  updatedAt: Date;
  visibility: number;
  categoryId: number;
  category: Category;
}

export interface Category {
  categoryId: number;
  categoryName: string;
  postedContent: Post[];
}

@Injectable({
  providedIn: 'root'
})
export class DataService {

  posts: Post[];

  constructor(private _http: HttpClient) {
    this.posts = [
      {
        contentId: 1,
        title: 'Toast Stuff',
        body: 'French Toast',
        createdAt: new Date(),
        updatedAt: new Date(),
        visibility: 0,
        categoryId: 0,
        category: {
          categoryId: 0,
          categoryName: 'Toast',
          postedContent: []
        }
      },
      {
        contentId: 2,
        title: 'Taco Stuff',
        body: 'Soft Taco',
        createdAt: new Date(),
        updatedAt: new Date(),
        visibility: 0,
        categoryId: 1,
        category: {
          categoryId: 1,
          categoryName: 'Taco',
          postedContent: []
        }
      },
      {
        contentId: 3,
        title: 'Hello World Stuff',
        body: 'Hello World',
        createdAt: new Date(),
        updatedAt: new Date(),
        visibility: 0,
        categoryId: 3,
        category: {
          categoryId: 3,
          categoryName: 'HelloWorld',
          postedContent: []
        }
      },
      {
        contentId: 4,
        title: 'Hello World Hello World Hello World Stuff',
        body: 'Hello World',
        createdAt: new Date(),
        updatedAt: new Date(),
        visibility: 0,
        categoryId: 3,
        category: {
          categoryId: 3,
          categoryName: 'HelloWorld',
          postedContent: []
        }
      }
    ];
  }

  getAllPosts(): Observable<Post[]> {
    return this._http.get<Post[]>('/api/contents')
  }

  getPostById(id: number): Observable<Post> {
    return this._http.get<Post>('/api/contents/' + id)
    /*
    return this._http.get<Post>('/api/contents/' + id).pipe(
      tap(x => {
        console.log('Fired getPostById with the following object', x);
      }),
      delay(5000),
      tap(x => {
        console.log('Completed delay', x);
      }),
    );
    */
  }

  createPost(post: Post): Observable<Post> {
    return this._http.post<Post>('/api/contents/', post)
  }

  updatePost(id: number, post: Post): Observable<Post> {
    return this._http.put<Post>('/api/contents/' + id, post)
  }

  deletePostById(id: number): Observable<any> {
    return this._http.delete<any>('api/contents/' + id)
  }

  deletePost(post: Post): Observable<any> {
    return this._http.delete<any>('api/contents/' + post.contentId)
  }

}
