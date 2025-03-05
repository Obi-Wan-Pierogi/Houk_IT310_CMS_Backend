import { Component, OnInit } from '@angular/core';
import { DataService, Post } from '../data.service';
import { ActivatedRoute, Router } from '@angular/router';
import { mergeMap } from 'rxjs/internal/operators/mergeMap';
import { tap } from 'rxjs';


@Component({
  selector: 'app-post-detail',
  templateUrl: './post-detail.component.html',
  styleUrl: './post-detail.component.css'
})
export class PostDetailComponent implements OnInit{
  id: number = 0;
  post: Post | undefined;

  constructor(private data: DataService,
    private route: ActivatedRoute,
    private router: Router) {

    this.id = 0;
    this.post = {
      contentId: 0,
      title: 'Not Found',
      body: 'The requested post was not found.',
      createdAt: new Date(),
      updatedAt: new Date(),
      visibility: 0,
      categoryId: 0,
      category: {
        categoryId: 0,
        categoryName: 'Error',
        postedContent: []
      }
    };
  }
  ngOnInit(): void {
    this.route.paramMap.pipe(
      tap(console.log),
      mergeMap(params => {
        this.id = Number(params.get("id"));
        return this.data.getPostById(this.id);
      })
    ).subscribe(data => {
      console.log(data);
      this.post = data;
    });
  }
}
