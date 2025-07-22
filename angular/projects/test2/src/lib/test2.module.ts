import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { test2Component } from './components/test2.component';
import { test2RoutingModule } from './test2-routing.module';

@NgModule({
  declarations: [test2Component],
  imports: [CoreModule, ThemeSharedModule, test2RoutingModule],
  exports: [test2Component],
})
export class test2Module {
  static forChild(): ModuleWithProviders<test2Module> {
    return {
      ngModule: test2Module,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<test2Module> {
    return new LazyModuleFactory(test2Module.forChild());
  }
}
