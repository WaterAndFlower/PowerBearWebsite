function e(e,n,i,t){return new(i||(i=Promise))((function(s,o){function r(e){try{h(t.next(e))}catch(e){o(e)}}function a(e){try{h(t.throw(e))}catch(e){o(e)}}function h(e){var n;e.done?s(e.value):(n=e.value,n instanceof i?n:new i((function(e){e(n)}))).then(r,a)}h((t=t.apply(e,n||[])).next())}))}class n{constructor(e,n,i){if(!i)throw new Error("the handle cannot be null");e?(e._swiper&&(e._swiper.instance.destroy(!0),delete e._swiper),this.handle=i,null!=n||(n={}),n.pagination&&(n.pagination.type=n.pagination.type.toLowerCase()),this.swiper=new Swiper(e,n),this.swiper.on("realIndexChange",(e=>this.onRealIndexChange(e,this))),e._swiper={instance:this.swiper,handle:i}):i.dispose()}slideTo(e,n,i){this.swiper.slideToLoop(e,n,i)}slideNext(e){this.swiper.slideNext(e)}slidePrev(e){this.swiper.slidePrev(e)}dispose(){this.swiper&&this.swiper.destroy(!0),this.handle.dispose()}onRealIndexChange(n,i){return e(this,void 0,void 0,(function*(){i.handle&&(yield i.handle.invokeMethodAsync("OnIndexChanged",n.realIndex))}))}}function i(e,i,t){return new n(e,i,t)}export{i as init};
//# sourceMappingURL=swiper-proxy.js.map