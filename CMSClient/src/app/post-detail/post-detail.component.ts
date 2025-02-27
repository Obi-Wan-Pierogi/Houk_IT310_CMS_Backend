import { Component } from '@angular/core';
import { DataService, Page } from '../data.service';
import { ActivatedRoute } from '@angular/router';
import { Router } from 'express';

@Component({
  selector: 'app-post-detail',
  templateUrl: './post-detail.component.html',
  styleUrl: './post-detail.component.css'
})
export class PostDetailComponent {
  id: number = 0;
  post: Page | undefined;

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
    this.initComponent();
  }

  initComponent() {
    this.route.paramMap.subscribe(params => {
      this.id = Number(params.get("id"));
      this.post = this.data.pages.find(p => p.contentId == this.id);
    });

    
  }

}
