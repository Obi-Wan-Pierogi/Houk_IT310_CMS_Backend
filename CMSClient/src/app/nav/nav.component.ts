import { Component } from '@angular/core';

interface PageLink {
  id: number,
  component: Component | undefined,
  displayName: string,
}

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrl: './nav.component.css'
})
export class NavComponent {
  staticPages: PageLink[] = [
    {
      id: 1,
      component: undefined,
      displayName: 'Taco News'
    },
    {
      id: 2,
      component: undefined,
      displayName: 'Toast Post'
    },
    {
      id: 3,
      component: undefined,
      displayName: 'Hello'
    },
    {
      id: 4,
      component: undefined,
      displayName: 'Hello World'
    }
  ];
}
