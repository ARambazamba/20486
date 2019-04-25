import { BrowserModule } from "@angular/platform-browser";
import { NgModule, LOCALE_ID } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { RouterModule, Routes } from "@angular/router";
import { registerLocaleData } from "@angular/common";
import { HttpClientModule } from "@angular/common/http";
import localeDe from "@angular/common/locales/de";

import { AppComponent } from "./app.component";
import { PageNotFoundComponent } from "./shared/page-not-found/page-not-found.component";
import { HomeComponent } from "./home/home.component";
import { MarkerListComponent } from "./markers/marker-list/marker-list.component";
import { MarkerItemComponent } from "./markers/marker-item/marker-item.component";
import { NavBarComponent } from "./shared/nav-bar/nav-bar.component";
import { FooterBarComponent } from "./shared/footer-bar/footer-bar.component";
import { SidebarComponent } from "./shared/sidebar/sidebar.component";

registerLocaleData(localeDe);

const appRoutes: Routes = [
  {
    path: "",
    component: HomeComponent
  },
  {
    path: "markers",
    component: MarkerListComponent
  },
  {
    path: "markers/:id",
    component: MarkerItemComponent
  },
  { path: "**", component: PageNotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MarkerListComponent,
    MarkerItemComponent,
    NavBarComponent,
    FooterBarComponent,
    PageNotFoundComponent,
    SidebarComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes, { enableTracing: false })
  ],
  providers: [{ provide: LOCALE_ID, useValue: "de-DE" }],
  bootstrap: [AppComponent]
})
export class AppModule {}
