using UnityEngine;

public class AudioManager : MonoBehaviour {
   [SerializeField] private AudioSource _bgSound;
   [SerializeField] private AudioSource _buttonClick;
   [SerializeField] private AudioSource _jump;
   [SerializeField] private AudioSource _barrier;
   [SerializeField] private AudioSource _hit;
   [SerializeField] private AudioSource _switchWindow;

   public void PlayButton(bool state) => SwitchSource(_buttonClick, state);

   public void PlayJump(bool state) => SwitchSource(_jump, state);
   public void PlayBarrier(bool state) => SwitchSource(_barrier, state);
   public void PlayHit(bool state) => SwitchSource(_hit, state);
   public void PlayBg(bool state) => SwitchSource(_bgSound, state);
   public void PlayOpenWindow(bool state) => SwitchSource(_switchWindow, state);

   private void SwitchSource(AudioSource source, bool state) {
      if(state) source.Play();
      else source.Stop();
   }
}
