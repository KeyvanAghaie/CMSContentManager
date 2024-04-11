import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CMSContentDto, CMSContentService } from '@proxy/cmscontents';
@Component({
  selector: 'app-view',
  standalone: true,
  imports: [],
  templateUrl: './view.component.html',
  styleUrl: './view.component.scss'
})
export class ViewComponent implements OnInit {
  public dto: Partial<CMSContentDto>={};
  constructor(private apiService: CMSContentService, private route: ActivatedRoute) {
  }
  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      const {id} = params;
      this.apiService.getCMSContentByIdAndCancellationToken(id, null).subscribe(dto => {
        this.dto = dto;
      })
    });
  }


}
