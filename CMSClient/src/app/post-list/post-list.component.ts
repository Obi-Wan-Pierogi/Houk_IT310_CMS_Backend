import { Component } from '@angular/core';
import { DataService, Post } from '../data.service';

@Component({
  selector: 'app-post-list',
  templateUrl: './post-list.component.html',
  styleUrl: './post-list.component.css'
})
export class PostListComponent {
  posts: Post[] = [];
  constructor(private data: DataService) {
    this.data.getAllPosts().subscribe(data => {
      this.posts = data;
    })
  }

  onDelete(id: number) {
    console.log('Delete post with id: ', id);

    let deletedPost = this.posts.find(post => post.contentId === id);
    console.log("found post", deletedPost);

    if (deletedPost != undefined) {
      console.log("deleting post", deletedPost);
      this.data.deletePost(deletedPost).subscribe(result => {
        console.log("post deleted", result);
        this.posts = this.posts.filter(p => p.contentId !== id);
      });
    }
  };
}

