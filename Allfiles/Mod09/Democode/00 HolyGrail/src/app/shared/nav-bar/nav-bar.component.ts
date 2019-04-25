import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-nav-bar",
  templateUrl: "./nav-bar.component.html",
  styleUrls: ["./nav-bar.component.scss"]
})
export class NavBarComponent implements OnInit {
  constructor() {}

  links = [
    { Title: "List", Link: "/" },
    { Title: "Markers", Link: "/markers" },
    { Title: "Add", Link: "/add" }
  ];

  ngOnInit() {}
}
