import { EventEmitter, Injectable, Output } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MenuUpdaterService {
  @Output() updateTrigger= new EventEmitter();
  constructor() { }
}
